using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.OrderBy;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal sealed class EndHavingClause<TEndType> : AbstractQueryStatement<HavingClauseBuilder, TEndType>,
        IEndHavingClause<TEndType>, IClauseStart<IEndHavingClause<TEndType>>
    {
        public EndHavingClause(ExpressionBuilder expressionBuilder, Expression<Func<bool>> searchCondition, TEndType endClosure)
            : base(new HavingClauseBuilder(expressionBuilder, searchCondition), endClosure)
        {
        }

        public IQueryOperand<TEndType> Union()
        {
            Statement.Append((IEndHavingClause<TEndType> input) => input.Union());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.Union, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> UnionAll()
        {
            Statement.Append((IEndHavingClause<TEndType> input) => input.UnionAll());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.UnionAll, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Except()
        {
            Statement.Append((IEndHavingClause<TEndType> input) => input.Except());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.Except, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Intersect()
        {
            Statement.Append((IEndHavingClause<TEndType> input) => input.Intersect());
            return new QueryOperand<TEndType>(ExpressionBuilder, QueryOperators.Intersect, EndClosure).AsNextClause(Statement);
        }

        public IOrderByCollate<TEndType> OrderBy(Expression<Func<object>> expression)
        {
            Statement.Append((IEndHavingClause<TEndType> input) => input.OrderBy(null), expression);
            return new OrderByCollate<TEndType>(ExpressionBuilder, expression, EndClosure).AsNextClause(Statement);
        }

        public IForBrowseOrXml<TEndType> For()
        {
            Statement.Append((IEndHavingClause<TEndType> input) => input.For());
            return new ForBrowseOrXml<TEndType>(ExpressionBuilder, EndClosure).AsNextClause(Statement);
        }

        public IEndHavingClause<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
