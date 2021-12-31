using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query.Select
{
    public interface ISelectClauseWithTop<TEndType> : ISelectClause<TEndType>
    {
        ISelectClauseWithPercent<TEndType> Top(Expression<Func<Integer>> count);
    }
}
