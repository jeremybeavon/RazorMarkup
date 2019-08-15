using System;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed partial class SqlSourceCodeVisitor : AbstractSqlVisitor<ISqlString>
    {
        public override void ExplicitVisit(CreateAvailabilityGroupStatement node)
        {
            throw new NotSupportedException();
        }
    }
}
