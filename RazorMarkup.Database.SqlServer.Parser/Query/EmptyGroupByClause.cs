using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.OrderBy;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class EmptyGroupByClause<TEndType> : IEndGroupByClause<TEndType>
    {
        private readonly IEndWhereClause<TEndType> groupByClause;

        public EmptyGroupByClause(IEndWhereClause<TEndType> groupByClause)
        {
            this.groupByClause = groupByClause;
        }

        public TEndType End()
        {
            return groupByClause.End();
        }

        public IEndHavingClause<TEndType> Having(Expression<Func<bool>> searchCondition)
        {
            throw new NotSupportedException();
        }

        public IQueryOperand<TEndType> Union()
        {
            return groupByClause.Union();
        }

        public IQueryOperand<TEndType> UnionAll()
        {
            return groupByClause.UnionAll();
        }

        public IQueryOperand<TEndType> Except()
        {
            return groupByClause.Except();
        }

        public IQueryOperand<TEndType> Intersect()
        {
            return groupByClause.Intersect();
        }

        public IOrderByCollate<TEndType> OrderBy(Expression<Func<object>> expression)
        {
            return groupByClause.OrderBy(expression);
        }

        public IForBrowseOrXml<TEndType> For()
        {
            return groupByClause.For();
        }
    }
}
