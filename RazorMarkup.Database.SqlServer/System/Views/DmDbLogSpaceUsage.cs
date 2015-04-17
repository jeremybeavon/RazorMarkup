using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbLogSpaceUsage
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_db_log_space_usage");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlBigInt> TotalLogSizeInBytes = new Column<SqlBigInt>("total_log_size_in_bytes");
        
        public static readonly Column<SqlBigInt> UsedLogSpaceInBytes = new Column<SqlBigInt>("used_log_space_in_bytes");
        
        public static readonly Column<SqlReal> UsedLogSpaceInPercent = new Column<SqlReal>("used_log_space_in_percent");
    }
}
