using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeClause : IHideObjectMethods
    {
        IMergeTopPercent Top(Expression<Func<Integer>> count);
    }
}
