using RazorMarkup.Database.SqlServer.Query.GroupBy;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IGroupByClause<TEndType> : IHideObjectMethods
    {
        IGroupByAnd<TEndType> GroupBy(Expression<Func<object>> groupingExpression);

        IGroupByFunction<TEndType> GroupBy();
    }
}
