using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranCurrentTransaction
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_tran_current_transaction");
        
        public static readonly Column<SqlBigInt> FirstSnapshotSequenceNum = new Column<SqlBigInt>("first_snapshot_sequence_num");
        
        public static readonly Column<SqlBigInt> FirstUsefulSequenceNum = new Column<SqlBigInt>("first_useful_sequence_num");
        
        public static readonly Column<SqlBigInt> LastTransactionSequenceNum = new Column<SqlBigInt>("last_transaction_sequence_num");
        
        public static readonly Column<SqlBigInt> TransactionId = new Column<SqlBigInt>("transaction_id");
        
        public static readonly Column<SqlBit> TransactionIsSnapshot = new Column<SqlBit>("transaction_is_snapshot");
        
        public static readonly Column<SqlBigInt> TransactionSequenceNum = new Column<SqlBigInt>("transaction_sequence_num");
    }
}
