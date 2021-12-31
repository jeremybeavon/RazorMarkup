using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranSessionTransactions
    {
        public static readonly ViewName ViewName = new("sys.dm_tran_session_transactions");

        public static readonly Column<SqlInt> EnlistCount = new("enlist_count");

        public static readonly Column<SqlBit> IsBound = new("is_bound");

        public static readonly Column<SqlBit> IsEnlisted = new("is_enlisted");

        public static readonly Column<SqlBit> IsLocal = new("is_local");

        public static readonly Column<SqlBit> IsUserTransaction = new("is_user_transaction");

        public static readonly Column<SqlInt> OpenTransactionCount = new("open_transaction_count");

        public static readonly Column<SqlInt> SessionId = new("session_id");

        public static readonly Column<SqlBinary> TransactionDescriptor = new("transaction_descriptor");

        public static readonly Column<SqlBigInt> TransactionId = new("transaction_id");
    }
}
