using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranSessionTransactions
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_tran_session_transactions");
        
        public static readonly Column<SqlInt> EnlistCount = new Column<SqlInt>("enlist_count");
        
        public static readonly Column<SqlBit> IsBound = new Column<SqlBit>("is_bound");
        
        public static readonly Column<SqlBit> IsEnlisted = new Column<SqlBit>("is_enlisted");
        
        public static readonly Column<SqlBit> IsLocal = new Column<SqlBit>("is_local");
        
        public static readonly Column<SqlBit> IsUserTransaction = new Column<SqlBit>("is_user_transaction");
        
        public static readonly Column<SqlInt> OpenTransactionCount = new Column<SqlInt>("open_transaction_count");
        
        public static readonly Column<SqlInt> SessionId = new Column<SqlInt>("session_id");
        
        public static readonly Column<SqlBinary> TransactionDescriptor = new Column<SqlBinary>("transaction_descriptor");
        
        public static readonly Column<SqlBigInt> TransactionId = new Column<SqlBigInt>("transaction_id");
    }
}
