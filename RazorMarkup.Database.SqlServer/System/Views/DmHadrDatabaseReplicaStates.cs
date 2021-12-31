using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrDatabaseReplicaStates
    {
        public static readonly ViewName ViewName = new("sys.dm_hadr_database_replica_states");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlTinyInt> DatabaseState = new("database_state");

        public static readonly Column<SqlNVarchar> DatabaseStateDesc = new("database_state_desc");

        public static readonly Column<SqlNumeric> EndOfLogLsn = new("end_of_log_lsn");

        public static readonly Column<SqlBigInt> FilestreamSendRate = new("filestream_send_rate");

        public static readonly Column<SqlUniqueIdentifier> GroupDatabaseId = new("group_database_id");

        public static readonly Column<SqlUniqueIdentifier> GroupId = new("group_id");

        public static readonly Column<SqlBit> IsCommitParticipant = new("is_commit_participant");

        public static readonly Column<SqlBit> IsLocal = new("is_local");

        public static readonly Column<SqlBit> IsSuspended = new("is_suspended");

        public static readonly Column<SqlNumeric> LastCommitLsn = new("last_commit_lsn");

        public static readonly Column<SqlDateTime> LastCommitTime = new("last_commit_time");

        public static readonly Column<SqlNumeric> LastHardenedLsn = new("last_hardened_lsn");

        public static readonly Column<SqlDateTime> LastHardenedTime = new("last_hardened_time");

        public static readonly Column<SqlNumeric> LastReceivedLsn = new("last_received_lsn");

        public static readonly Column<SqlDateTime> LastReceivedTime = new("last_received_time");

        public static readonly Column<SqlNumeric> LastRedoneLsn = new("last_redone_lsn");

        public static readonly Column<SqlDateTime> LastRedoneTime = new("last_redone_time");

        public static readonly Column<SqlNumeric> LastSentLsn = new("last_sent_lsn");

        public static readonly Column<SqlDateTime> LastSentTime = new("last_sent_time");

        public static readonly Column<SqlBigInt> LogSendQueueSize = new("log_send_queue_size");

        public static readonly Column<SqlBigInt> LogSendRate = new("log_send_rate");

        public static readonly Column<SqlBigInt> LowWaterMarkForGhosts = new("low_water_mark_for_ghosts");

        public static readonly Column<SqlNumeric> RecoveryLsn = new("recovery_lsn");

        public static readonly Column<SqlBigInt> RedoQueueSize = new("redo_queue_size");

        public static readonly Column<SqlBigInt> RedoRate = new("redo_rate");

        public static readonly Column<SqlUniqueIdentifier> ReplicaId = new("replica_id");

        public static readonly Column<SqlTinyInt> SuspendReason = new("suspend_reason");

        public static readonly Column<SqlNVarchar> SuspendReasonDesc = new("suspend_reason_desc");

        public static readonly Column<SqlTinyInt> SynchronizationHealth = new("synchronization_health");

        public static readonly Column<SqlNVarchar> SynchronizationHealthDesc = new("synchronization_health_desc");

        public static readonly Column<SqlTinyInt> SynchronizationState = new("synchronization_state");

        public static readonly Column<SqlNVarchar> SynchronizationStateDesc = new("synchronization_state_desc");

        public static readonly Column<SqlNumeric> TruncationLsn = new("truncation_lsn");
    }
}
