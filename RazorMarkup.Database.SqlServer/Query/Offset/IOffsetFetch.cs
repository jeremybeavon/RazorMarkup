using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Query.Offset
{
    public interface IOffsetFetch<TEndType> : IEndOffsetClause<TEndType>
    {
        IOffsetFetchRow<TEndType> FetchFirst(Expression<Func<Integer>> expression);

        IOffsetFetchRow<TEndType> FetchNext(Expression<Func<Integer>> expression);
    }
}
