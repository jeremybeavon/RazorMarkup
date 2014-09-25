using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Query
{
    public interface IHavingClause<TEndType> : IHideObjectMethods
    {
        IEndHavingClause<TEndType> Having(Expression<Func<bool>> searchCondition);
    }
}
