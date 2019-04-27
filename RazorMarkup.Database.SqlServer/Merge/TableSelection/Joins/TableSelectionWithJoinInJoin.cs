using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Merge.TableSelection.Joins
{
    internal class TableSelectionWithJoinInJoin<TJoinEndType> : AbstractJoinStatement<TJoinEndType>,
        ITableSelectionWithJoinInJoin<TJoinEndType>
    {
        public TableSelectionWithJoinInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        private ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> TableSource
        {
            get { return new TableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>>(Statement, this); }
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> InnerJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.InnerJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> InnerLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER LOOP"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.InnerLoopJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> InnerHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER HASH"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.InnerHashJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> InnerMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER MERGE"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.InnerMergeJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> InnerRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER REMOTE"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.InnerRemoteJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> LeftJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.LeftJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> LeftLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT LOOP"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.LeftLoopJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> LeftHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT HASH"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.LeftHashJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> LeftMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT MERGE"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.LeftMergeJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> LeftRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT REMOTE"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.LeftRemoteJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> RightJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.RightJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> RightLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT LOOP"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.RightLoopJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> RightHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT HASH"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.RightHashJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> RightMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT MERGE"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.RightMergeJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> RightRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT REMOTE"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.RightRemoteJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> FullJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.FullJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> FullLoopJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL LOOP"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.FullLoopJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> FullHashJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL HASH"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.FullHashJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> FullMergeJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL MERGE"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.FullMergeJoin());
            return TableSource;
        }

        public ITableSourceInJoin<ITableSelectionWithJoinInJoin<TJoinEndType>> FullRemoteJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL REMOTE"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.FullRemoteJoin());
            return TableSource;
        }

        public ITableSourceInJoin<TJoinEndType> CrossJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "CROSS"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.CrossJoin());
            return new TableSourceInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public TJoinEndType On(Expression<Func<bool>> searchCondition)
        {
            Statement.Statements.Add(new JoinConditionBuilder(ExpressionBuilder, searchCondition));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.On(null), searchCondition);
            return JoinClosure;
        }
    }
}
