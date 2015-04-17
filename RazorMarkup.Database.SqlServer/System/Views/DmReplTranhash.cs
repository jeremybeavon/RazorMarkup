using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmReplTranhash
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_repl_tranhash");
        
        public static readonly Column<SqlInt> Buckets = new Column<SqlInt>("buckets");
        
        public static readonly Column<SqlInt> CompensatedTrans = new Column<SqlInt>("compensated_trans");
        
        public static readonly Column<SqlInt> CompletedTrans = new Column<SqlInt>("completed_trans");
        
        public static readonly Column<SqlNVarchar> FirstBeginLsn = new Column<SqlNVarchar>("first_begin_lsn");
        
        public static readonly Column<SqlInt> HashedTrans = new Column<SqlInt>("hashed_trans");
        
        public static readonly Column<SqlNVarchar> LastCommitLsn = new Column<SqlNVarchar>("last_commit_lsn");
    }
}
