using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    public interface IGroupByGroupingSetFunction<TEndType> : IHideObjectMethods
    {
        IGroupByCube<IGroupByGroupingSet<TEndType>> Cube(Expression<Func<object>> groupingExpression);

        IGroupByCubeFunction<IGroupByGroupingSet<TEndType>> Cube();

        IGroupByRollup<IGroupByGroupingSet<TEndType>> Rollup(Expression<Func<object>> groupingExpression);

        IGroupByRollupFunction<IGroupByGroupingSet<TEndType>> Rollup();

        IGroupByGroup<IGroupByGroupingSet<TEndType>> Group(Expression<Func<object>> groupingExpression);

        IGroupByGroupingSet<TEndType> GrandTotal();
    }
}
