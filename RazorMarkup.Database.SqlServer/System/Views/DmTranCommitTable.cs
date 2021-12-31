using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranCommitTable
    {
        public static readonly ViewName ViewName = new("sys.dm_tran_commit_table");

        public static readonly Column<SqlBigInt> CommitCsn = new("commit_csn");

        public static readonly Column<SqlBigInt> CommitLbn = new("commit_lbn");

        public static readonly Column<SqlDateTime> CommitTime = new("commit_time");

        public static readonly Column<SqlBigInt> CommitTs = new("commit_ts");

        public static readonly Column<SqlBigInt> XdesId = new("xdes_id");
    }
}
