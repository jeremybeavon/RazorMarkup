using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Parser.TableSelection;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class TableReferenceVisitor : AbstractSqlVisitor<ICommonTableSelectionWithJoin>
    {
        private readonly ICommonTableSource tableSource;

        public TableReferenceVisitor(ICommonTableSource tableSource)
	    {
            this.tableSource = tableSource;
	    }

        public override void ExplicitVisit(NamedTableReference node)
        {
            ICommonTableSelectionWithAlias selectionWithAlias = tableSource.Table(node.SchemaObject.ToTableName());
            ICommonTableSelectionWithTableSample selectionWithTableSample =
                node.Alias == null ? selectionWithAlias : selectionWithAlias.WithAlias(new TableAlias(node.Alias.Value));
            ICommonTableSelectionWithTableHint selectionWithTableHint = BuildTableSample(selectionWithTableSample, node);
            Result = BuildTableHint(selectionWithTableHint, node);
        }

        public override void ExplicitVisit(PivotedTableReference node)
        {
            ICommonTableSelectionWithJoin table = node.TableReference.AcceptWithResult(new TableReferenceVisitor(tableSource));
            throw new NotImplementedException();
        }

        public override void ExplicitVisit(QualifiedJoin node)
        {
            ICommonTableSelectionWithJoin firstTable = node.FirstTableReference.AcceptWithResult(
                new TableReferenceVisitor(tableSource));
            ICommonTableSourceWithJoinHint secondTableSource = null;
            switch (node.QualifiedJoinType)
            {
                case QualifiedJoinType.Inner:
                    secondTableSource = firstTable.InnerJoin();
                    break;
                case QualifiedJoinType.LeftOuter:
                    secondTableSource = firstTable.LeftJoin();
                    break;
                case QualifiedJoinType.RightOuter:
                    secondTableSource = firstTable.RightJoin();
                    break;
                case QualifiedJoinType.FullOuter:
                    secondTableSource = firstTable.FullJoin();
                    break;  
            }

            ICommonTableSelectionWithJoin secondTable = node.SecondTableReference.AcceptWithResult(
                new TableReferenceVisitor(secondTableSource));
            Result = secondTable.On(node.SearchCondition.ToExpression());
        }

        public override void ExplicitVisit(UnpivotedTableReference node)
        {
            ICommonTableSelectionWithJoin table = node.TableReference.AcceptWithResult(new TableReferenceVisitor(tableSource));
            Result = table
                .Unpivot(new ColumnName(node.ValueColumn.Value))
                .For(new ColumnName(node.PivotColumn.Value))
                .In(node.InColumns.Select(column => column.ToColumnName()).ToArray())
                .As(new TableAlias(node.Alias.Value));
        }

        public override void ExplicitVisit(UnqualifiedJoin node)
        {
            ICommonTableSelectionWithJoin firstTable = node.FirstTableReference.AcceptWithResult(
                new TableReferenceVisitor(tableSource));
            ICommonTableSource secondTableSource = null;
            switch (node.UnqualifiedJoinType)
            {
                case UnqualifiedJoinType.CrossJoin:
                    secondTableSource = firstTable.CrossJoin();
                    break;
                case UnqualifiedJoinType.CrossApply:
                    secondTableSource = firstTable.CrossApplyJoin();
                    break;
                case UnqualifiedJoinType.OuterApply:
                    secondTableSource = firstTable.OuterApplyJoin();
                    break;
            }

            Result = node.SecondTableReference.AcceptWithResult(new TableReferenceVisitor(secondTableSource));
        }

        private static ICommonTableSelectionWithTableHint BuildTableSample(
            ICommonTableSelectionWithTableSample tableSampleClause,
            NamedTableReference tableReference)
        {
            if (tableReference.TableSampleClause == null)
            {
                return tableSampleClause;
            }

            TableSampleClause clause = tableReference.TableSampleClause;
            ICommonTableSampleWithSystem tableSampleWithSystem = tableSampleClause.TableSample();
            ICommonTableSample tableSample = clause.System ? tableSampleWithSystem.System() : tableSampleWithSystem;
            ICommonTableSelectionWithRepeatable selectionWithRepeatable = null;
            switch (clause.TableSampleClauseOption)
            {
                case TableSampleClauseOption.NotSpecified:
                    selectionWithRepeatable = tableSample.Sample(clause.SampleNumber.ToExpression<Integer>());
                    break;
                case TableSampleClauseOption.Percent:
                    selectionWithRepeatable = tableSample.Percent(clause.SampleNumber.ToExpression<Float>());
                    break;
                case TableSampleClauseOption.Rows:
                    selectionWithRepeatable = tableSample.Rows(clause.SampleNumber.ToExpression<Integer>());
                    break;
            }

            return clause.RepeatSeed == null ?
                selectionWithRepeatable :
                selectionWithRepeatable.WithRepeatSeed(clause.RepeatSeed.ToExpression<Integer>());
        }

        private static ICommonTableSelectionWithJoin BuildTableHint(
            ICommonTableSelectionWithTableHint tableHint,
            NamedTableReference node)
        {
            if (node.TableHints.Count == 0)
            {
                return tableHint;
            }

            ICommonTableSelectionWithAdditionalTableHint currentTableHint = null;
            foreach (TableHint hintNode in node.TableHints)
            {
                currentTableHint = BuildTableHint(currentTableHint == null ? tableHint.WithHint() : currentTableHint.And(), hintNode);
            }

            return currentTableHint;
        }

        private static ICommonTableSelectionWithAdditionalTableHint BuildTableHint(
            ICommonTableHint tableHint,
            TableHint node)
        {
            ICommonTableSelectionWithAdditionalTableHint simpleHint = BuildSimpleTableHint(tableHint, node);
            if (simpleHint != null)
            {
                return simpleHint;
            }

            throw new NotImplementedException();
        }

        private static ICommonTableSelectionWithAdditionalTableHint BuildSimpleTableHint(
            ICommonTableHint tableHint,
            TableHint node)
        {
            switch (node.HintKind)
            {
                case TableHintKind.ForceScan:
                    return tableHint.ForceScan();
                case TableHintKind.HoldLock:
                    return tableHint.HoldLock();
                case TableHintKind.NoExpand:
                    return tableHint.NoExpand();
                case TableHintKind.NoLock:
                    return tableHint.NoLock();
                case TableHintKind.NoWait:
                    return tableHint.NoWait();
                case TableHintKind.PagLock:
                    return tableHint.PageLock();
                case TableHintKind.ReadCommitted:
                    return tableHint.ReadCommitted();
                case TableHintKind.ReadCommittedLock:
                    return tableHint.ReadCommittedLock();
                case TableHintKind.ReadPast:
                    return tableHint.ReadPast();
                case TableHintKind.ReadUncommitted:
                    return tableHint.ReadUncommitted();
                case TableHintKind.RepeatableRead:
                    return tableHint.RepeatableRead();
                case TableHintKind.Rowlock:
                    return tableHint.RowLock();
                case TableHintKind.Serializable:
                    return tableHint.Serializable();
                case TableHintKind.Snapshot:
                    return tableHint.Snapshot();
                case TableHintKind.TabLock:
                    return tableHint.TabLock();
                case TableHintKind.TabLockX:
                    return tableHint.TabLockX();
                case TableHintKind.UpdLock:
                    return tableHint.UpdateLock();
                case TableHintKind.XLock:
                    return tableHint.XLock();
                default:
                    return null;
            }
        }
    }
}
