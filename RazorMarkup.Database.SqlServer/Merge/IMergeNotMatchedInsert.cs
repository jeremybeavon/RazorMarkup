using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Merge
{
    public interface IMergeNotMatchedInsert : IHideObjectMethods
    {
        IMergeNotMatchedInsertAnd Values(Expression<Func<object>> value);

        IEndWhenClause DefaultValues();
    }
}
