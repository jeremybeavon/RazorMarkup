using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    public interface IGroupByGroupingSetsFunction<TEndType> : IHideObjectMethods
    {
        IGroupByCube<IGroupByGroupingSets<TEndType>> Cube(Expression<Func<object>> groupingExpression);

        IGroupByCubeFunction<IGroupByGroupingSets<TEndType>> Cube();

        IGroupByRollup<IGroupByGroupingSets<TEndType>> Rollup(Expression<Func<object>> groupingExpression);

        IGroupByRollupFunction<IGroupByGroupingSets<TEndType>> Rollup();

        IGroupByGroupingSets<TEndType> GrandTotal();
    }
}
