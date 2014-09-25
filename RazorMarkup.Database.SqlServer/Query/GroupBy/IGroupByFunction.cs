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

        IGroupByGroupingSet<TEndType> GroupingSet(Expression<Func<object>> groupingExpression);

        IGroupByGroupingSetFunction<TEndType> GroupingSet();

        IGroupByGroup<IGroupByAnd<TEndType>> Group(Expression<Func<object>> groupingExpression);

        IGroupByAnd<TEndType> GrandTotal();
    }
}
