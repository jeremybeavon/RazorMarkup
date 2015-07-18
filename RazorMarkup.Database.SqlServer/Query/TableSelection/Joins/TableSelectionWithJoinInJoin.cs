using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.Query.TableSelection.Joins
{
    internal class TableSelectionWithJoinInJoin<TJoinEndType> : AbstractJoinStatement<TJoinEndType>,
        ITableSelectionWithJoinInJoin<TJoinEndType>
    {
        public TableSelectionWithJoinInJoin(FromClauseBuilder statement, TJoinEndType joinClosure)
            : base(statement, joinClosure)
        {
        }

        private ITableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TJoinEndType>> TableSource
        {
            get { return new TableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TJoinEndType>>(Statement, this); }
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TJoinEndType>> InnerJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "INNER"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.InnerJoin());
            return TableSource;
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TJoinEndType>> LeftJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.LeftJoin());
            return TableSource;
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TJoinEndType>> RightJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.RightJoin());
            return TableSource;
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TJoinEndType>> FullJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL"));
            Statement.Append((ITableSelectionWithJoinInJoin<TJoinEndType> input) => input.FullJoin());
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
