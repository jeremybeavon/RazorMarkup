using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.Delete
{
    public interface IDeleteStatementWithTop : IDeleteStatement
    {
        IDeleteStatementWithPercent Top(Expression<Func<Numeric>> expression);
    }
}
