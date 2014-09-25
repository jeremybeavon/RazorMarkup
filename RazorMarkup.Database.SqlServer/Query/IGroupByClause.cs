using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Query.GroupBy;

namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IGroupByClause<TEndType> : IHideObjectMethods
    {
        IGroupByAnd<TEndType> GroupBy(Expression<Func<object>> groupingExpression);

        IGroupByFunction<TEndType> GroupBy();
    }
}
