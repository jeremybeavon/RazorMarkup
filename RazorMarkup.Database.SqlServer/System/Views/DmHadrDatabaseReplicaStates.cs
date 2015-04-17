using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmHadrDatabaseReplicaStates
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_hadr_database_replica_states");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlTinyInt> DatabaseState = new Column<SqlTinyInt>("database_state");
        
        public static readonly Column<SqlNVarchar> DatabaseStateDesc = new Column<SqlNVarchar>("database_state_desc");
        
        public static readonly Column<SqlNumeric> EndOfLogLsn = new Column<SqlNumeric>("end_of_log_lsn");
        
        public static readonly Column<SqlBigInt> FilestreamSendRate = new Column<SqlBigInt>("filestream_send_rate");
        
        public static readonly Column<SqlUniqueIdentifier> GroupDatabaseId = new Column<SqlUniqueIdentifier>("group_database_id");
        
        public static readonly Column<SqlUniqueIdentifier> GroupId = new Column<SqlUniqueIdentifier>("group_id");
        
        public static readonly Column<SqlBit> IsCommitParticipant = new Column<SqlBit>("is_commit_participant");
        
        public static readonly Column<SqlBit> IsLocal = new Column<SqlBit>("is_local");
        
        public static readonly Column<SqlBit> IsSuspended = new Column<SqlBit>("is_suspended");
        
        public static readonly Column<SqlNumeric> LastCommitLsn = new Column<SqlNumeric>("last_commit_lsn");
        
        public static readonly Column<SqlDateTime> LastCommitTime = new Column<SqlDateTime>("last_commit_time");
        
        public static readonly Column<SqlNumeric> LastHardenedLsn = new Column<SqlNumeric>("last_hardened_lsn");
        
        public static readonly Column<SqlDateTime> LastHardenedTime = new Column<SqlDateTime>("last_hardened_time");
        
        public static readonly Column<SqlNumeric> LastReceivedLsn = new Column<SqlNumeric>("last_received_lsn");
        
        public static readonly Column<SqlDateTime> LastReceivedTime = new Column<SqlDateTime>("last_received_time");
        
        public static readonly Column<SqlNumeric> LastRedoneLsn = new Column<SqlNumeric>("last_redone_lsn");
        
        public static readonly Column<SqlDateTime> LastRedoneTime = new Column<SqlDateTime>("last_redone_time");
        
        public static readonly Column<SqlNumeric> LastSentLsn = new Column<SqlNumeric>("last_sent_lsn");
        
        public static readonly Column<SqlDateTime> LastSentTime = new Column<SqlDateTime>("last_sent_time");
        
        public static readonly Column<SqlBigInt> LogSendQueueSize = new Column<SqlBigInt>("log_send_queue_size");
        
        public static readonly Column<SqlBigInt> LogSendRate = new Column<SqlBigInt>("log_send_rate");
        
        public static readonly Column<SqlBigInt> LowWaterMarkForGhosts = new Column<SqlBigInt>("low_water_mark_for_ghosts");
        
        public static readonly Column<SqlNumeric> RecoveryLsn = new Column<SqlNumeric>("recovery_lsn");
        
        public static readonly Column<SqlBigInt> RedoQueueSize = new Column<SqlBigInt>("redo_queue_size");
        
        public static readonly Column<SqlBigInt> RedoRate = new Column<SqlBigInt>("redo_rate");
        
        public static readonly Column<SqlUniqueIdentifier> ReplicaId = new Column<SqlUniqueIdentifier>("replica_id");
        
        public static readonly Column<SqlTinyInt> SuspendReason = new Column<SqlTinyInt>("suspend_reason");
        
        public static readonly Column<SqlNVarchar> SuspendReasonDesc = new Column<SqlNVarchar>("suspend_reason_desc");
        
        public static readonly Column<SqlTinyInt> SynchronizationHealth = new Column<SqlTinyInt>("synchronization_health");
        
        public static readonly Column<SqlNVarchar> SynchronizationHealthDesc = new Column<SqlNVarchar>("synchronization_health_desc");
        
        public static readonly Column<SqlTinyInt> SynchronizationState = new Column<SqlTinyInt>("synchronization_state");
        
        public static readonly Column<SqlNVarchar> SynchronizationStateDesc = new Column<SqlNVarchar>("synchronization_state_desc");
        
        public static readonly Column<SqlNumeric> TruncationLsn = new Column<SqlNumeric>("truncation_lsn");
    }
}
