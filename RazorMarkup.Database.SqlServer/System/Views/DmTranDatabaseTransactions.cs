using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranDatabaseTransactions
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_tran_database_transactions");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlNumeric> DatabaseTransactionBeginLsn = new Column<SqlNumeric>("database_transaction_begin_lsn");
        
        public static readonly Column<SqlDateTime> DatabaseTransactionBeginTime = new Column<SqlDateTime>("database_transaction_begin_time");
        
        public static readonly Column<SqlNumeric> DatabaseTransactionCommitLsn = new Column<SqlNumeric>("database_transaction_commit_lsn");
        
        public static readonly Column<SqlNumeric> DatabaseTransactionLastLsn = new Column<SqlNumeric>("database_transaction_last_lsn");
        
        public static readonly Column<SqlNumeric> DatabaseTransactionLastRollbackLsn = new Column<SqlNumeric>("database_transaction_last_rollback_lsn");
        
        public static readonly Column<SqlBigInt> DatabaseTransactionLogBytesReserved = new Column<SqlBigInt>("database_transaction_log_bytes_reserved");
        
        public static readonly Column<SqlInt> DatabaseTransactionLogBytesReservedSystem = new Column<SqlInt>("database_transaction_log_bytes_reserved_system");
        
        public static readonly Column<SqlBigInt> DatabaseTransactionLogBytesUsed = new Column<SqlBigInt>("database_transaction_log_bytes_used");
        
        public static readonly Column<SqlInt> DatabaseTransactionLogBytesUsedSystem = new Column<SqlInt>("database_transaction_log_bytes_used_system");
        
        public static readonly Column<SqlBigInt> DatabaseTransactionLogRecordCount = new Column<SqlBigInt>("database_transaction_log_record_count");
        
        public static readonly Column<SqlNumeric> DatabaseTransactionMostRecentSavepointLsn = new Column<SqlNumeric>("database_transaction_most_recent_savepoint_lsn");
        
        public static readonly Column<SqlNumeric> DatabaseTransactionNextUndoLsn = new Column<SqlNumeric>("database_transaction_next_undo_lsn");
        
        public static readonly Column<SqlInt> DatabaseTransactionReplicateRecordCount = new Column<SqlInt>("database_transaction_replicate_record_count");
        
        public static readonly Column<SqlInt> DatabaseTransactionState = new Column<SqlInt>("database_transaction_state");
        
        public static readonly Column<SqlInt> DatabaseTransactionStatus = new Column<SqlInt>("database_transaction_status");
        
        public static readonly Column<SqlInt> DatabaseTransactionStatus2 = new Column<SqlInt>("database_transaction_status2");
        
        public static readonly Column<SqlInt> DatabaseTransactionType = new Column<SqlInt>("database_transaction_type");
        
        public static readonly Column<SqlBigInt> TransactionId = new Column<SqlBigInt>("transaction_id");
    }
}
