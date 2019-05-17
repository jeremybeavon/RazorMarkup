using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection
{
    internal class TableSelectionWithJoin : EndFromClause, ITableSelectionWithJoin
    {
        public TableSelectionWithJoin(FromClauseBuilder statement)
            : base(statement)
        {
        }

        public static ITableSelectionWithJoin Create(FromClauseBuilder statement)
        {
            return new TableSelectionWithJoin(statement);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> InnerJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER"));
            Statement.Append((ITableSelectionWithJoin input) => input.InnerJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> InnerLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER LOOP"));
            Statement.Append((ITableSelectionWithJoin input) => input.InnerLoopJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> InnerHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER HASH"));
            Statement.Append((ITableSelectionWithJoin input) => input.InnerHashJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> InnerMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER MERGE"));
            Statement.Append((ITableSelectionWithJoin input) => input.InnerMergeJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> InnerRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER REMOTE"));
            Statement.Append((ITableSelectionWithJoin input) => input.InnerRemoteJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> LeftJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT"));
            Statement.Append((ITableSelectionWithJoin input) => input.LeftJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> LeftLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT LOOP"));
            Statement.Append((ITableSelectionWithJoin input) => input.LeftLoopJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> LeftHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT HASH"));
            Statement.Append((ITableSelectionWithJoin input) => input.LeftHashJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> LeftMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT MERGE"));
            Statement.Append((ITableSelectionWithJoin input) => input.LeftMergeJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> LeftRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT REMOTE"));
            Statement.Append((ITableSelectionWithJoin input) => input.LeftRemoteJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> RightJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT"));
            Statement.Append((ITableSelectionWithJoin input) => input.RightJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> RightLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT LOOP"));
            Statement.Append((ITableSelectionWithJoin input) => input.RightLoopJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> RightHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT HASH"));
            Statement.Append((ITableSelectionWithJoin input) => input.RightHashJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> RightMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT MERGE"));
            Statement.Append((ITableSelectionWithJoin input) => input.RightMergeJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> RightRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT REMOTE"));
            Statement.Append((ITableSelectionWithJoin input) => input.RightRemoteJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> FullJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL"));
            Statement.Append((ITableSelectionWithJoin input) => input.FullJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> FullLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL LOOP"));
            Statement.Append((ITableSelectionWithJoin input) => input.FullLoopJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> FullHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL HASH"));
            Statement.Append((ITableSelectionWithJoin input) => input.FullHashJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> FullMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL MERGE"));
            Statement.Append((ITableSelectionWithJoin input) => input.FullMergeJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin> FullRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL REMOTE"));
            Statement.Append((ITableSelectionWithJoin input) => input.FullRemoteJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin>(Statement, this);
        }

        public ITableSource CrossJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " CROSS JOIN"));
            Statement.Append((ITableSelectionWithJoin input) => input.CrossJoin());
            return new TableSource(Statement);
        }

        public ITableSource CrossApplyJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " CROSS APPLY"));
            Statement.Append((ITableSelectionWithJoin input) => input.CrossApplyJoin());
            return new TableSource(Statement);
        }

        public ITableSource OuterApplyJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " OUTER APPLY"));
            Statement.Append((ITableSelectionWithJoin input) => input.OuterApplyJoin());
            return new TableSource(Statement);
        }

        public IPivotClause Pivot(AggregateName aggregateName, params Expression<Func<Text>>[] aggregateValues)
        {
            throw new NotImplementedException();
        }

        public IUnpivotClause Unpivot(ColumnName columnName)
        {
            throw new NotImplementedException();
        }

        public ITableSource And()
        {
            Statement.CurrentTable.IncludeComma = true;
            Statement.Append((ITableSelectionWithJoin input) => input.And());
            return new TableSource(Statement);
        }
    }
}
