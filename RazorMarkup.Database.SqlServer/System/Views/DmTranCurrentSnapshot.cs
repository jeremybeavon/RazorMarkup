using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranCurrentSnapshot
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_tran_current_snapshot");
        
        public static readonly Column<SqlBigInt> TransactionSequenceNum = new Column<SqlBigInt>("transaction_sequence_num");
    }
}
