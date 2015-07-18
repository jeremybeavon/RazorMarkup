using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Builders;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.TableSelection.Joins
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
            return TableSource;
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TJoinEndType>> LeftJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "LEFT"));
            return TableSource;
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TJoinEndType>> RightJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "RIGHT"));
            return TableSource;
        }

        public ITableSourceWithJoinHint<ITableSelectionWithJoinInJoin<TJoinEndType>> FullJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "FULL"));
            return TableSource;
        }

        public ITableSourceInJoin<TJoinEndType> CrossJoin()
        {
            Statement.Statements.Add(new JoinQueryBuilder(ExpressionBuilder, "CROSS"));
            return new TableSourceInJoin<TJoinEndType>(Statement, JoinClosure);
        }

        public TJoinEndType On(Expression<Func<bool>> searchCondition)
        {
            Statement.Statements.Add(new JoinConditionBuilder(ExpressionBuilder, searchCondition));
            return JoinClosure;
        }
    }
}
