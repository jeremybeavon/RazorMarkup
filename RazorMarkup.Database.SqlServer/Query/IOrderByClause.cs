using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.OrderBy;

namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IOrderByClause<TEndType> : IHideObjectMethods
    {
        IOrderByCollate<TEndType> OrderBy(Expression<Func<object>> expression);
    }
}
