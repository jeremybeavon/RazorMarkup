using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.OrderBy
{
    public interface IOrderByAnd<TEndType> : IEndOrderByClause<TEndType>
    {
        IOrderByWithCollate<TEndType> OrderBy(Expression<Func<object>> expression);
    }
}
