using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.GroupBy
{
    public interface IGroupByAnd<TEndType> : IEndGroupByClause<TEndType>
    {
        IGroupByFunction<TEndType> And();

        IGroupByAnd<TEndType> And(Expression<Func<object>> groupingExpression);
    }
}
