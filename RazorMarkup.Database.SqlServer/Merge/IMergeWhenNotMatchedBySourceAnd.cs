using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeWhenNotMatchedBySourceAnd : IMergeWhenNotMatchedBySource
    {
        IMergeWhenNotMatchedBySource And(Expression<Func<bool>> condition);
    }
}
