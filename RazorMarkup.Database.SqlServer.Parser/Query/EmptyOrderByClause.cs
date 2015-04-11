using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query;
using RazorMarkup.Database.SqlServer.Query.For;
using RazorMarkup.Database.SqlServer.Query.Offset;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Parser.Query
{
    internal sealed class EmptyOrderByClause<TEndType> : IEndOrderByClause<TEndType>
    {
        private readonly IEndHavingClause<TEndType> orderByClause;

        public EmptyOrderByClause(IEndHavingClause<TEndType> orderByClause)
        {
            this.orderByClause = orderByClause;
        }

        public TEndType End()
        {
            return orderByClause.End();
        }

        public IOffsetRow<TEndType> Offset(Expression<Func<Integer>> expression)
        {
            throw new NotSupportedException();
        }

        public IForBrowseOrXml<TEndType> For()
        {
            return orderByClause.For();
        }
    }
}
