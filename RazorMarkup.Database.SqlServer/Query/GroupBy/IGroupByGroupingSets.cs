using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    public interface IGroupByGroupingSets<TEndType> : IHideObjectMethods
    {
        IGroupByGroupingSets<TEndType> And(Expression<Func<object>> groupingExpression);

        IGroupByGroupingSetsFunction<TEndType> And();

        IGroupByAnd<TEndType> EndGroupingSets();
    }
}
