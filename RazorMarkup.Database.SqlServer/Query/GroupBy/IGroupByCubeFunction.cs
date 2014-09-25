using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    public interface IGroupByCubeFunction<TEndCubeType> : IHideObjectMethods
    {
        IGroupByGroup<IGroupByCube<TEndCubeType>> Group(Expression<Func<object>> groupingExpression);
    }
}
