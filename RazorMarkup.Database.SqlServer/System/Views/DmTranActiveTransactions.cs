using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranActiveTransactions
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_tran_active_transactions");
        
        public static readonly Column<SqlInt> DtcIsolationLevel = new Column<SqlInt>("dtc_isolation_level");
        
        public static readonly Column<SqlInt> DtcState = new Column<SqlInt>("dtc_state");
        
        public static readonly Column<SqlInt> DtcStatus = new Column<SqlInt>("dtc_status");
        
        public static readonly Column<SqlVarbinary> FilestreamTransactionId = new Column<SqlVarbinary>("filestream_transaction_id");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlDateTime> TransactionBeginTime = new Column<SqlDateTime>("transaction_begin_time");
        
        public static readonly Column<SqlBigInt> TransactionId = new Column<SqlBigInt>("transaction_id");
        
        public static readonly Column<SqlInt> TransactionState = new Column<SqlInt>("transaction_state");
        
        public static readonly Column<SqlInt> TransactionStatus = new Column<SqlInt>("transaction_status");
        
        public static readonly Column<SqlInt> TransactionStatus2 = new Column<SqlInt>("transaction_status2");
        
        public static readonly Column<SqlInt> TransactionType = new Column<SqlInt>("transaction_type");
        
        public static readonly Column<SqlUniqueIdentifier> TransactionUow = new Column<SqlUniqueIdentifier>("transaction_uow");
    }
}
