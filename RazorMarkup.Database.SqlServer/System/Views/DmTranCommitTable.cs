using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranCommitTable
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_tran_commit_table");
        
        public static readonly Column<SqlBigInt> CommitCsn = new Column<SqlBigInt>("commit_csn");
        
        public static readonly Column<SqlBigInt> CommitLbn = new Column<SqlBigInt>("commit_lbn");
        
        public static readonly Column<SqlDateTime> CommitTime = new Column<SqlDateTime>("commit_time");
        
        public static readonly Column<SqlBigInt> CommitTs = new Column<SqlBigInt>("commit_ts");
        
        public static readonly Column<SqlBigInt> XdesId = new Column<SqlBigInt>("xdes_id");
    }
}
