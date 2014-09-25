using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    public interface IGroupByCube<TEndCubeType> : IHideObjectMethods
    {
        IGroupByCube<TEndCubeType> And(Expression<Func<object>> groupingExpression);

        IGroupByCubeFunction<TEndCubeType> And();

        TEndCubeType EndCube();
    }
}
