using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.GroupBy;
using RazorMarkup.Database.SqlServer.Query.Offset;
using RazorMarkup.Database.SqlServer.Query.OrderBy;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class EmptyWhereClause<TEndType> : IEndWhereClause<TEndType>
    {
        private readonly IEndFromClause<TEndType> whereClause;

        public EmptyWhereClause(IEndFromClause<TEndType> whereClause)
        {
            this.whereClause = whereClause;
        }

        public TEndType End()
        {
            return whereClause.End();
        }

        public IGroupByAnd<TEndType> GroupBy(Expression<Func<object>> groupingExpression)
        {
            return whereClause.GroupBy(groupingExpression);
        }

        public IGroupByFunction<TEndType> GroupBy()
        {
            return whereClause.GroupBy();
        }

        public IQueryOperand<TEndType> Union()
        {
            return whereClause.Union();
        }

        public IQueryOperand<TEndType> UnionAll()
        {
            return whereClause.UnionAll();
        }

        public IQueryOperand<TEndType> Except()
        {
            return whereClause.Except();
        }

        public IQueryOperand<TEndType> Intersect()
        {
            return whereClause.Intersect();
        }

        public IOrderByCollate<TEndType> OrderBy(Expression<Func<object>> expression)
        {
            return whereClause.OrderBy(expression);
        }

        public IForBrowseOrXml<TEndType> For()
        {
            return whereClause.For();
        }
    }
}
