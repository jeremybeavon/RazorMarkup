using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeClause : IMergeTargetTable
    {
        IMergeTopPercent Top(Expression<Func<Integer>> count);
    }
}
