using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbLogSpaceUsage
    {
        public static readonly ViewName ViewName = new("sys.dm_db_log_space_usage");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlBigInt> TotalLogSizeInBytes = new("total_log_size_in_bytes");

        public static readonly Column<SqlBigInt> UsedLogSpaceInBytes = new("used_log_space_in_bytes");

        public static readonly Column<SqlReal> UsedLogSpaceInPercent = new("used_log_space_in_percent");
    }
}
