using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrAvailabilityReplicaClusterNodes
    {
        public static readonly ViewName ViewName = new("sys.dm_hadr_availability_replica_cluster_nodes");

        public static readonly Column<SqlNVarchar> GroupName = new("group_name");

        public static readonly Column<SqlNVarchar> NodeName = new("node_name");

        public static readonly Column<SqlNVarchar> ReplicaServerName = new("replica_server_name");
    }
}
