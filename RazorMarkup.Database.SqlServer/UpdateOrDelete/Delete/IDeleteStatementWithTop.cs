using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.UpdateOrDelete.Delete
{
    public interface IDeleteStatementWithTop : IDeleteStatement
    {
        IDeleteStatementWithPercent Top(Expression<Func<Numeric>> expression);
    }
}
