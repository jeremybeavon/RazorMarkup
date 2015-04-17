using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranActiveSnapshotDatabaseTransactions
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_tran_active_snapshot_database_transactions");
        
        public static readonly Column<SqlFloat> AverageVersionChainTraversed = new Column<SqlFloat>("average_version_chain_traversed");
        
        public static readonly Column<SqlBigInt> CommitSequenceNum = new Column<SqlBigInt>("commit_sequence_num");
        
        public static readonly Column<SqlBigInt> ElapsedTimeSeconds = new Column<SqlBigInt>("elapsed_time_seconds");
        
        public static readonly Column<SqlBigInt> FirstSnapshotSequenceNum = new Column<SqlBigInt>("first_snapshot_sequence_num");
        
        public static readonly Column<SqlBit> IsSnapshot = new Column<SqlBit>("is_snapshot");
        
        public static readonly Column<SqlInt> MaxVersionChainTraversed = new Column<SqlInt>("max_version_chain_traversed");
        
        public static readonly Column<SqlInt> SessionId = new Column<SqlInt>("session_id");
        
        public static readonly Column<SqlBigInt> TransactionId = new Column<SqlBigInt>("transaction_id");
        
        public static readonly Column<SqlBigInt> TransactionSequenceNum = new Column<SqlBigInt>("transaction_sequence_num");
    }
}
