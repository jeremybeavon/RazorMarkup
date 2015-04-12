using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Query.Builders;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.GroupBy;
using RazorMarkup.Database.SqlServer.Query.Offset;
using RazorMarkup.Database.SqlServer.Query.OrderBy;
using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query
{
    internal class EndFromClause<TEndType> : AbstractQueryStatement<FromClauseBuilder, TEndType>, IEndFromClause<TEndType>
    {
        public EndFromClause(FromClauseBuilder statement, TEndType endClosure)
            : base(statement, endClosure)
        {
        }

        public IEndWhereClause<TEndType> Where(Expression<Func<bool>> searchCondition)
        {
            return new EndWhereClause<TEndType>(Expression, searchCondition, EndClosure).AsNextClause(Statement);
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

        public IOffsetRow<TEndType> Offset(Expression<Func<Integer>> expression)
        {
            return new OffsetRow<TEndType>(Expression, expression, EndClosure).AsNextClause(Statement);
        }

        public IForBrowseOrXml<TEndType> For()
        {
            return new ForBrowseOrXml<TEndType>(Expression, EndClosure).AsNextClause(Statement);
        }
    }
}
