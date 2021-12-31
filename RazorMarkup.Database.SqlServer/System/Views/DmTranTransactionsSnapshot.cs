using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranTransactionsSnapshot
    {
        public static readonly ViewName ViewName = new("sys.dm_tran_transactions_snapshot");

        public static readonly Column<SqlInt> SnapshotId = new("snapshot_id");

        public static readonly Column<SqlBigInt> SnapshotSequenceNum = new("snapshot_sequence_num");

        public static readonly Column<SqlBigInt> TransactionSequenceNum = new("transaction_sequence_num");
    }
}
