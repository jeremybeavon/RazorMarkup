using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrDatabaseReplicaClusterStates
    {
        public static readonly ViewName ViewName = new("sys.dm_hadr_database_replica_cluster_states");

        public static readonly Column<SqlNVarchar> DatabaseName = new("database_name");

        public static readonly Column<SqlUniqueIdentifier> GroupDatabaseId = new("group_database_id");

        public static readonly Column<SqlBit> IsDatabaseJoined = new("is_database_joined");

        public static readonly Column<SqlBit> IsFailoverReady = new("is_failover_ready");

        public static readonly Column<SqlBit> IsPendingSecondarySuspend = new("is_pending_secondary_suspend");

        public static readonly Column<SqlNumeric> RecoveryLsn = new("recovery_lsn");

        public static readonly Column<SqlUniqueIdentifier> ReplicaId = new("replica_id");

        public static readonly Column<SqlNumeric> TruncationLsn = new("truncation_lsn");
    }
}
