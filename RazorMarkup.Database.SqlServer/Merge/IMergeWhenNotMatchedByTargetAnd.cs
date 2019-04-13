using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeWhenNotMatchedByTargetAnd : IMergeWhenNotMatchedByTarget
    {
        IMergeWhenNotMatchedByTarget And(Expression<Func<bool>> condition);
    }
}
