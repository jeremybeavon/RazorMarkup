using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrDatabaseReplicaClusterStates
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_hadr_database_replica_cluster_states");
        
        public static readonly Column<SqlNVarchar> DatabaseName = new Column<SqlNVarchar>("database_name");
        
        public static readonly Column<SqlUniqueIdentifier> GroupDatabaseId = new Column<SqlUniqueIdentifier>("group_database_id");
        
        public static readonly Column<SqlBit> IsDatabaseJoined = new Column<SqlBit>("is_database_joined");
        
        public static readonly Column<SqlBit> IsFailoverReady = new Column<SqlBit>("is_failover_ready");
        
        public static readonly Column<SqlBit> IsPendingSecondarySuspend = new Column<SqlBit>("is_pending_secondary_suspend");
        
        public static readonly Column<SqlNumeric> RecoveryLsn = new Column<SqlNumeric>("recovery_lsn");
        
        public static readonly Column<SqlUniqueIdentifier> ReplicaId = new Column<SqlUniqueIdentifier>("replica_id");
        
        public static readonly Column<SqlNumeric> TruncationLsn = new Column<SqlNumeric>("truncation_lsn");
    }
}
