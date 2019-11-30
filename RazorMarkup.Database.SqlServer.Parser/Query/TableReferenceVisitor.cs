using System;
using System.Collections.Generic;
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

        public override void ExplicitVisit(InlineDerivedTable node)
        {
            Expression<Func<object>>[][] values = new Expression<Func<object>>[node.RowValues.Count][];
            for (int rowIndex = 0; rowIndex < node.RowValues.Count; rowIndex++)
            {
                IList<ScalarExpression> columnValues = node.RowValues[rowIndex].ColumnValues;
                values[rowIndex] = new Expression<Func<object>>[columnValues.Count];
                for (int columnIndex = 0; columnIndex < columnValues.Count; columnIndex++)
                {
                    values[rowIndex][columnIndex] = columnValues[columnIndex].ToExpression<object>();
                }
            }

            ICommonDerivedTableWithAlias derivedTable = tableSource.DerivedTable(values);
            Result = derivedTable.As(
                new TableAlias(node.Alias.Value),
                node.Columns.Select(column => new ColumnAlias(column.Value)).ToArray());
        }

        public override void ExplicitVisit(NamedTableReference node)
        {
            ICommonTableSelectionWithAlias selectionWithAlias = tableSource.Table(node.SchemaObject.ToTableName());
            ICommonTableSelectionWithTableSample selectionWithTableSample =
                node.Alias == null ? (ICommonTableSelectionWithTableSample)selectionWithAlias: selectionWithAlias.As(new TableAlias(node.Alias.Value));
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
            ICommonTableSource secondTableSource = null;
            switch (node.QualifiedJoinType)
            {
                case QualifiedJoinType.Inner:
                    secondTableSource = BuildInnerJoin(firstTable, node.JoinHint);
                    break;
                case QualifiedJoinType.LeftOuter:
                    secondTableSource = BuildLeftJoin(firstTable, node.JoinHint);
                    break;
                case QualifiedJoinType.RightOuter:
                    secondTableSource = BuildRightJoin(firstTable, node.JoinHint);
                    break;
                case QualifiedJoinType.FullOuter:
                    secondTableSource = BuildFullJoin(firstTable, node.JoinHint);
                    break;
            }

            ICommonTableSelectionWithJoin secondTable = node.SecondTableReference.AcceptWithResult(
                new TableReferenceVisitor(secondTableSource));
            Result = secondTable.On(node.SearchCondition.ToExpression());
        }

        public override void ExplicitVisit(QueryDerivedTable node)
        {
            ICommonSubqueryWithAlias subqueryWithAlias = tableSource.Subquery(node.QueryExpression);
            ColumnAlias[] columns = node.Columns.Select(column => new ColumnAlias(column.Value)).ToArray();
            Result = subqueryWithAlias.As(new TableAlias(node.Alias.Value), columns);
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
                (ICommonTableSelectionWithTableHint)selectionWithRepeatable:
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
                //currentTableHint = BuildTableHint(currentTableHint == null ? tableHint.WithHint() : currentTableHint.And(), hintNode);
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

        private static ICommonTableSource BuildInnerJoin(ICommonTableSelectionWithJoin firstTable, JoinHint joinHint)
        {
            switch (joinHint)
            {
                case JoinHint.None:
                    return firstTable.InnerJoin();
                case JoinHint.Loop:
                    return firstTable.InnerLoopJoin();
                case JoinHint.Hash:
                    return firstTable.InnerHashJoin();
                case JoinHint.Merge:
                    return firstTable.InnerMergeJoin();
                case JoinHint.Remote:
                    return firstTable.InnerRemoteJoin();
                default:
                    return null;
            }
        }

        private static ICommonTableSource BuildLeftJoin(ICommonTableSelectionWithJoin firstTable, JoinHint joinHint)
        {
            switch (joinHint)
            {
                case JoinHint.None:
                    return firstTable.LeftJoin();
                case JoinHint.Loop:
                    return firstTable.LeftLoopJoin();
                case JoinHint.Hash:
                    return firstTable.LeftHashJoin();
                case JoinHint.Merge:
                    return firstTable.LeftMergeJoin();
                case JoinHint.Remote:
                    return firstTable.LeftRemoteJoin();
                default:
                    return null;
            }
        }

        private static ICommonTableSource BuildRightJoin(ICommonTableSelectionWithJoin firstTable, JoinHint joinHint)
        {
            switch (joinHint)
            {
                case JoinHint.None:
                    return firstTable.RightJoin();
                case JoinHint.Loop:
                    return firstTable.RightLoopJoin();
                case JoinHint.Hash:
                    return firstTable.RightHashJoin();
                case JoinHint.Merge:
                    return firstTable.RightMergeJoin();
                case JoinHint.Remote:
                    return firstTable.RightRemoteJoin();
                default:
                    return null;
            }
        }

        private static ICommonTableSource BuildFullJoin(ICommonTableSelectionWithJoin firstTable, JoinHint joinHint)
        {
            switch (joinHint)
            {
                case JoinHint.None:
                    return firstTable.FullJoin();
                case JoinHint.Loop:
                    return firstTable.FullLoopJoin();
                case JoinHint.Hash:
                    return firstTable.FullHashJoin();
                case JoinHint.Merge:
                    return firstTable.FullMergeJoin();
                case JoinHint.Remote:
                    return firstTable.FullRemoteJoin();
                default:
                    return null;
            }
        }
    }
}
