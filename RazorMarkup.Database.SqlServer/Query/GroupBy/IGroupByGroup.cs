using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    public interface IGroupByGroup<TEndGroupType> : IHideObjectMethods
    {
        IGroupByGroup<TEndGroupType> And(Expression<Func<object>> groupingExpression);

        TEndGroupType EndGroup();
    }
}
