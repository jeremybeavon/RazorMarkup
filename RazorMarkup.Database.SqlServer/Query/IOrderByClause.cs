using RazorMarkup.Database.SqlServer.Query.OrderBy;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IOrderByClause<TEndType> : IHideObjectMethods
    {
        IOrderByCollate<TEndType> OrderBy(Expression<Func<object>> expression);
    }
}
