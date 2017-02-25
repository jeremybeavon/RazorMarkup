using System;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Create.ServerAudit
{
    public interface ICreateServerAuditWhere : ISqlString
    {
        ISqlString Where(Expression<Func<bool>> predicateExpression);
    }
}
