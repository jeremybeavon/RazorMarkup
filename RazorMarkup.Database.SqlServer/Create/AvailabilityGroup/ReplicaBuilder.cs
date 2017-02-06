using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Create.AvailabilityGroup
{
    internal sealed class ReplicaBuilder : AbstractStatementTextBuilder
    {
        public ReplicaBuilder(string serverInstance)
        {
            ServerInstance = serverInstance;
        }

        public string ServerInstance { get; private set; }

        public string EndpointUrl { get; set; }

        public string AvailabilityMode { get; set; }

        public string FailoverMode { get; set; }
        
        public int? BackupPriority { get; set; }

        public string SecondaryRoleAllowConnections { get; set; }

        public string SecondaryRoleReadOnlyRoutingUrl { get; set; }

        public string PrimaryRoleAllowConnections { get; set; }

        public string PrimaryRoleReadOnlyRoutingList { get; set; }

        public int? SessionTimeout { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
