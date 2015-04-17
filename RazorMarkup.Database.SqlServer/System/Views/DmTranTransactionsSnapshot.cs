using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranTransactionsSnapshot
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_tran_transactions_snapshot");
        
        public static readonly Column<SqlInt> SnapshotId = new Column<SqlInt>("snapshot_id");
        
        public static readonly Column<SqlBigInt> SnapshotSequenceNum = new Column<SqlBigInt>("snapshot_sequence_num");
        
        public static readonly Column<SqlBigInt> TransactionSequenceNum = new Column<SqlBigInt>("transaction_sequence_num");
    }
}
