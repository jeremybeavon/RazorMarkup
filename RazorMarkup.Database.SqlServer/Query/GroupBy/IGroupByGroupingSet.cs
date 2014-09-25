using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    public interface IGroupByGroupingSet<TEndType> : IHideObjectMethods
    {
        IGroupByGroupingSet<TEndType> And(Expression<Func<object>> groupingExpression);

        IGroupByGroupingSetFunction<TEndType> And();

        IGroupByAnd<TEndType> EndGroupingSet();
    }
}
