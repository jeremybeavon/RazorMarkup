using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    public interface IGroupByFunction<TEndType> : IHideObjectMethods
    {
        IGroupByCube<IGroupByAnd<TEndType>> Cube(Expression<Func<object>> groupingExpression);

        IGroupByCubeFunction<IGroupByAnd<TEndType>> Cube();

        IGroupByRollup<IGroupByAnd<TEndType>> Rollup(Expression<Func<object>> groupingExpression);

        IGroupByRollupFunction<IGroupByAnd<TEndType>> Rollup();

        IGroupByGroupingSets<TEndType> GroupingSets(Expression<Func<object>> groupingExpression);

        IGroupByGroupingSetsFunction<TEndType> GroupingSets();

        IGroupByAnd<TEndType> GrandTotal();
    }
}
