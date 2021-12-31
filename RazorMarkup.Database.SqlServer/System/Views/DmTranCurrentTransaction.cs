using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranCurrentTransaction
    {
        public static readonly ViewName ViewName = new("sys.dm_tran_current_transaction");

        public static readonly Column<SqlBigInt> FirstSnapshotSequenceNum = new("first_snapshot_sequence_num");

        public static readonly Column<SqlBigInt> FirstUsefulSequenceNum = new("first_useful_sequence_num");

        public static readonly Column<SqlBigInt> LastTransactionSequenceNum = new("last_transaction_sequence_num");

        public static readonly Column<SqlBigInt> TransactionId = new("transaction_id");

        public static readonly Column<SqlBit> TransactionIsSnapshot = new("transaction_is_snapshot");

        public static readonly Column<SqlBigInt> TransactionSequenceNum = new("transaction_sequence_num");
    }
}
