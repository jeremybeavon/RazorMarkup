using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeNotMatchedInsertAnd : IEndWhenClause
    {
        IMergeNotMatchedInsertAnd And(Expression<Func<object>> value);
    }
}
