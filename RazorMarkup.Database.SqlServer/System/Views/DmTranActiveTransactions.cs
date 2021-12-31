using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranActiveTransactions
    {
        public static readonly ViewName ViewName = new("sys.dm_tran_active_transactions");

        public static readonly Column<SqlInt> DtcIsolationLevel = new("dtc_isolation_level");

        public static readonly Column<SqlInt> DtcState = new("dtc_state");

        public static readonly Column<SqlInt> DtcStatus = new("dtc_status");

        public static readonly Column<SqlVarbinary> FilestreamTransactionId = new("filestream_transaction_id");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlDateTime> TransactionBeginTime = new("transaction_begin_time");

        public static readonly Column<SqlBigInt> TransactionId = new("transaction_id");

        public static readonly Column<SqlInt> TransactionState = new("transaction_state");

        public static readonly Column<SqlInt> TransactionStatus = new("transaction_status");

        public static readonly Column<SqlInt> TransactionStatus2 = new("transaction_status2");

        public static readonly Column<SqlInt> TransactionType = new("transaction_type");

        public static readonly Column<SqlUniqueIdentifier> TransactionUow = new("transaction_uow");
    }
}
