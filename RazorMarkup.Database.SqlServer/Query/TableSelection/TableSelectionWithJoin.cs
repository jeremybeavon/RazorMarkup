using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.TableSelection.Joins;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection
{
    internal class TableSelectionWithJoin<TEndType> : EndFromClause<TEndType>, ITableSelectionWithJoin<TEndType>
    {
        public TableSelectionWithJoin(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.InnerJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER LOOP"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.InnerLoopJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER HASH"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.InnerHashJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER MERGE"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.InnerMergeJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> InnerRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER REMOTE"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.InnerRemoteJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.LeftJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT LOOP"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.LeftLoopJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT HASH"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.LeftHashJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT MERGE"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.LeftMergeJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> LeftRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT REMOTE"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.LeftRemoteJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.RightJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT LOOP"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.RightLoopJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT HASH"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.RightHashJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT MERGE"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.RightMergeJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> RightRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT REMOTE"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.RightRemoteJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.FullJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL LOOP"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.FullLoopJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL HASH"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.FullHashJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL MERGE"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.FullMergeJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSourceInJoin<ITableSelectionWithJoin<TEndType>> FullRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL REMOTE"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.FullRemoteJoin());
            return new TableSourceInJoin<ITableSelectionWithJoin<TEndType>>(Statement, this);
        }

        public ITableSource<TEndType> CrossJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " CROSS JOIN"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.CrossJoin());
            return new TableSource<TEndType>(Statement, EndClosure);
        }

        public ITableSource<TEndType> CrossApplyJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " CROSS APPLY"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.CrossApplyJoin());
            return new TableSource<TEndType>(Statement, EndClosure);
        }

        public ITableSource<TEndType> OuterApplyJoin()
        {
            Statement.Statements.Add(new RawTableReferenceBuilder(ExpressionBuilder, " OUTER APPLY"));
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.OuterApplyJoin());
            return new TableSource<TEndType>(Statement, EndClosure);
        }

        public IPivotClause<TEndType> Pivot(AggregateName aggregateName, params Expression<Func<Text>>[] aggregateValues)
        {
            throw new NotImplementedException();
        }

        public IUnpivotClause<TEndType> Unpivot(ColumnName columnName)
        {
            throw new NotImplementedException();
        }

        public ITableSource<TEndType> And()
        {
            Statement.CurrentTable.IncludeComma = true;
            Statement.Append((ITableSelectionWithJoin<TEndType> input) => input.And());
            return new TableSource<TEndType>(Statement, EndClosure);
        }
    }
}
