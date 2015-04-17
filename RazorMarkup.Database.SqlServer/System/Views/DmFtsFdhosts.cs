using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsFdhosts
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_fts_fdhosts");
        
        public static readonly Column<SqlInt> BatchCount = new Column<SqlInt>("batch_count");
        
        public static readonly Column<SqlInt> FdhostId = new Column<SqlInt>("fdhost_id");
        
        public static readonly Column<SqlNVarchar> FdhostName = new Column<SqlNVarchar>("fdhost_name");
        
        public static readonly Column<SqlInt> FdhostProcessId = new Column<SqlInt>("fdhost_process_id");
        
        public static readonly Column<SqlNVarchar> FdhostType = new Column<SqlNVarchar>("fdhost_type");
        
        public static readonly Column<SqlInt> MaxThread = new Column<SqlInt>("max_thread");
    }
}
