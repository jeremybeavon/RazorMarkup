using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    public interface IGroupByRollup<TEndRollupType> : IHideObjectMethods
    {
        IGroupByRollup<TEndRollupType> And(Expression<Func<object>> groupingExpression);

        IGroupByRollupFunction<TEndRollupType> And();

        TEndRollupType EndRollup();
    }
}
