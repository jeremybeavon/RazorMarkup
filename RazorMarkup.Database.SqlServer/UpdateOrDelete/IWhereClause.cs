using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete
{
    public interface IWhereClause : IOptionClause
    {
        IOptionClause Where(Expression<Func<bool>> searchCondition);

        ICursorWhereClause Where();
    }
}
