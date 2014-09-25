using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IWhereClause<TEndType> : IHideObjectMethods
    {
        IEndWhereClause<TEndType> Where(Expression<Func<bool>> searchCondition);
    }
}
