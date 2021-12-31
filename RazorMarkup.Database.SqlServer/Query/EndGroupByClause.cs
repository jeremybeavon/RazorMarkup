using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.OrderBy;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal class EndGroupByClause<TEndType> : AbstractQueryStatement<GroupByClauseBuilder, TEndType>,
        IEndGroupByClause<TEndType>
    {
        public EndGroupByClause(GroupByClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IEndHavingClause<TEndType> Having(Expression<Func<bool>> searchCondition)
        {
            Statement.Append((IEndGroupByClause<TEndType> input) => input.Having(null), searchCondition);
            return new EndHavingClause<TEndType>(ExpressionBuilder, searchCondition, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Union()
        {
            Statement.Append((IEndGroupByClause<TEndType> input) => input.Union());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.Union, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> UnionAll()
        {
            Statement.Append((IEndGroupByClause<TEndType> input) => input.UnionAll());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.UnionAll, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Except()
        {
            Statement.Append((IEndGroupByClause<TEndType> input) => input.Except());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.Except, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Intersect()
        {
            Statement.Append((IEndGroupByClause<TEndType> input) => input.Intersect());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.Intersect, EndClosure).AsNextClause(Statement);
        }

        public IOrderByCollate<TEndType> OrderBy(Expression<Func<object>> expression)
        {
            Statement.Append((IEndGroupByClause<TEndType> input) => input.OrderBy(null), expression);
            return new OrderByCollate<TEndType>(ExpressionBuilder, expression, EndClosure).AsNextClause(Statement);
        }

        public IForBrowseOrXml<TEndType> For()
        {
            Statement.Append((IEndGroupByClause<TEndType> input) => input.For());
            return new ForBrowseOrXml<TEndType>(ExpressionBuilder, EndClosure).AsNextClause(Statement);
        }
    }
}
