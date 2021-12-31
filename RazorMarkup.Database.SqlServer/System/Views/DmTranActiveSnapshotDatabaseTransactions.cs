using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranActiveSnapshotDatabaseTransactions
    {
        public static readonly ViewName ViewName = new("sys.dm_tran_active_snapshot_database_transactions");

        public static readonly Column<SqlFloat> AverageVersionChainTraversed = new("average_version_chain_traversed");

        public static readonly Column<SqlBigInt> CommitSequenceNum = new("commit_sequence_num");

        public static readonly Column<SqlBigInt> ElapsedTimeSeconds = new("elapsed_time_seconds");

        public static readonly Column<SqlBigInt> FirstSnapshotSequenceNum = new("first_snapshot_sequence_num");

        public static readonly Column<SqlBit> IsSnapshot = new("is_snapshot");

        public static readonly Column<SqlInt> MaxVersionChainTraversed = new("max_version_chain_traversed");

        public static readonly Column<SqlInt> SessionId = new("session_id");

        public static readonly Column<SqlBigInt> TransactionId = new("transaction_id");

        public static readonly Column<SqlBigInt> TransactionSequenceNum = new("transaction_sequence_num");
    }
}
