using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Create.AvailabilityGroup;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed partial class SqlSourceCodeVisitor : AbstractSqlVisitor<ISqlString>
    {
        public override void ExplicitVisit(CreateAvailabilityGroupStatement node)
        {
            ICreateAvailabilityGroupWith with = Sql.Create().AvailabilityGroup(new AvailabilityGroupName(node.Name.Value)).With();
			foreach (AvailabilityGroupOption option in node.Options)
            {

            }
        }
    }
}
