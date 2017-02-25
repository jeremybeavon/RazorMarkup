using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Create.ServerAudit
{
    public interface ICreateServerAuditWith : ISqlString
    {
        ISqlString Where(Expression<Func<bool>> predicateExpression);
    }
}
