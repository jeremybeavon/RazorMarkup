using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.OrderBy;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class EmptyHavingClause<TEndType> : IEndHavingClause<TEndType>
    {
        private readonly IEndGroupByClause<TEndType> havingClause;

        public EmptyHavingClause(IEndGroupByClause<TEndType> havingClause)
        {
            this.havingClause = havingClause;
        }

        public TEndType End()
        {
            return havingClause.End();
        }

        public IQueryOperand<TEndType> Union()
        {
            return havingClause.Union();
        }

        public IQueryOperand<TEndType> UnionAll()
        {
            return havingClause.UnionAll();
        }

        public IQueryOperand<TEndType> Except()
        {
            return havingClause.Except();
        }

        public IQueryOperand<TEndType> Intersect()
        {
            return havingClause.Intersect();
        }

        public IOrderByCollate<TEndType> OrderBy(Expression<Func<object>> expression)
        {
            return havingClause.OrderBy(expression);
        }

        public IForBrowseOrXml<TEndType> For()
        {
            return havingClause.For();
        }
    }
}
