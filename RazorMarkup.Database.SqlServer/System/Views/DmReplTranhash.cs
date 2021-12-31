using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmReplTranhash
    {
        public static readonly ViewName ViewName = new("sys.dm_repl_tranhash");

        public static readonly Column<SqlInt> Buckets = new("buckets");

        public static readonly Column<SqlInt> CompensatedTrans = new("compensated_trans");

        public static readonly Column<SqlInt> CompletedTrans = new("completed_trans");

        public static readonly Column<SqlNVarchar> FirstBeginLsn = new("first_begin_lsn");

        public static readonly Column<SqlInt> HashedTrans = new("hashed_trans");

        public static readonly Column<SqlNVarchar> LastCommitLsn = new("last_commit_lsn");
    }
}
