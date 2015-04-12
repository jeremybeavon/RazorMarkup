using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.GroupBy;
using RazorMarkup.Database.SqlServer.Query.OrderBy;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal class EndWhereClause<TEndType> : AbstractQueryStatement<WhereClauseBuilder, TEndType>,
        IEndWhereClause<TEndType>, IClauseStart<IEndWhereClause<TEndType>>
    {
        public EndWhereClause(Expression initialExpression, Expression<Func<bool>> searchCondition, TEndType endClosure)
            : base(new WhereClauseBuilder(initialExpression, searchCondition), endClosure)
        {
        }

        public IGroupByAnd<TEndType> GroupBy(Expression<Func<object>> groupingExpression)
        {
            return new GroupByAnd<TEndType>(groupingExpression, EndClosure).AsNextClause(Statement);
        }

        public IGroupByFunction<TEndType> GroupBy()
        {
            return new GroupByFunction<TEndType>(Expression, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Union()
        {
            return new QueryOperand<TEndType>(Expression, QueryOperators.Union, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> UnionAll()
        {
            return new QueryOperand<TEndType>(Expression, QueryOperators.UnionAll, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Except()
        {
            return new QueryOperand<TEndType>(Expression, QueryOperators.Except, EndClosure).AsNextClause(Statement);
        }

        public IQueryOperand<TEndType> Intersect()
        {
            return new QueryOperand<TEndType>(Expression, QueryOperators.Intersect, EndClosure).AsNextClause(Statement);
        }

        public IOrderByCollate<TEndType> OrderBy(Expression<Func<object>> expression)
        {
            return new OrderByCollate<TEndType>(Expression, expression, EndClosure).AsNextClause(Statement);
        }

        public IForBrowseOrXml<TEndType> For()
        {
            return new ForBrowseOrXml<TEndType>(Expression, EndClosure).AsNextClause(Statement);
        }

        public IEndWhereClause<TEndType> AsNextClause(ClauseBuilder statement)
        {
            statement.NextClause = Statement;
            return this;
        }
    }
}
