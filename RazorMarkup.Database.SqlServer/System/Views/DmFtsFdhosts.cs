using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsFdhosts
    {
        public static readonly ViewName ViewName = new("sys.dm_fts_fdhosts");

        public static readonly Column<SqlInt> BatchCount = new("batch_count");

        public static readonly Column<SqlInt> FdhostId = new("fdhost_id");

        public static readonly Column<SqlNVarchar> FdhostName = new("fdhost_name");

        public static readonly Column<SqlInt> FdhostProcessId = new("fdhost_process_id");

        public static readonly Column<SqlNVarchar> FdhostType = new("fdhost_type");

        public static readonly Column<SqlInt> MaxThread = new("max_thread");
    }
}
