using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrAvailabilityReplicaClusterStates
    {
        public static readonly ViewName ViewName = new("sys.dm_hadr_availability_replica_cluster_states");

        public static readonly Column<SqlUniqueIdentifier> GroupId = new("group_id");

        public static readonly Column<SqlTinyInt> JoinState = new("join_state");

        public static readonly Column<SqlNVarchar> JoinStateDesc = new("join_state_desc");

        public static readonly Column<SqlUniqueIdentifier> ReplicaId = new("replica_id");

        public static readonly Column<SqlNVarchar> ReplicaServerName = new("replica_server_name");
    }
}
