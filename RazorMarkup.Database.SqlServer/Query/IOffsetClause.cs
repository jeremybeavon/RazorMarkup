using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.Offset;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IOffsetClause<TEndType> : IHideObjectMethods
    {
        IOffsetRow<TEndType> Offset(Expression<Func<Integer>> expression);
    }
}
