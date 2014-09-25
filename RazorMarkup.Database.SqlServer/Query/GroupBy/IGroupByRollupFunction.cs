using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    public interface IGroupByRollupFunction<TEndRollupType> : IHideObjectMethods
    {
        IGroupByGroup<IGroupByRollup<TEndRollupType>> Group(Expression<Func<object>> groupingExpression);
    }
}
