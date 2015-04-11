using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.OrderBy
{
    public interface IOrderByAnd<TEndType> : IEndOrderByClause<TEndType>
    {
        IOrderByCollate<TEndType> And(Expression<Func<object>> expression);
    }
}
