using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IEndFromClause : ISqlString
    {
        IMergeWhen On(Expression<Func<bool>> searchCondition);
    }
}
