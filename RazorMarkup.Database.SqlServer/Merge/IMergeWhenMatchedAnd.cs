using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeWhenMatchedAnd : IMergeWhenMatched
    {
        IMergeWhenMatched And(Expression<Func<bool>> condition);
    }
}
