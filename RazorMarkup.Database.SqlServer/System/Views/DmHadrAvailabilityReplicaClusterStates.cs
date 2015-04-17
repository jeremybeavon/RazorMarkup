using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrAvailabilityReplicaClusterStates
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_hadr_availability_replica_cluster_states");
        
        public static readonly Column<SqlUniqueIdentifier> GroupId = new Column<SqlUniqueIdentifier>("group_id");
        
        public static readonly Column<SqlTinyInt> JoinState = new Column<SqlTinyInt>("join_state");
        
        public static readonly Column<SqlNVarchar> JoinStateDesc = new Column<SqlNVarchar>("join_state_desc");
        
        public static readonly Column<SqlUniqueIdentifier> ReplicaId = new Column<SqlUniqueIdentifier>("replica_id");
        
        public static readonly Column<SqlNVarchar> ReplicaServerName = new Column<SqlNVarchar>("replica_server_name");
    }
}
