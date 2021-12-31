using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbIndexUsageStats
    {
        public static readonly ViewName ViewName = new("sys.dm_db_index_usage_stats");

        public static readonly Column<SqlSmallInt> DatabaseId = new("database_id");

        public static readonly Column<SqlInt> IndexId = new("index_id");

        public static readonly Column<SqlDateTime> LastSystemLookup = new("last_system_lookup");

        public static readonly Column<SqlDateTime> LastSystemScan = new("last_system_scan");

        public static readonly Column<SqlDateTime> LastSystemSeek = new("last_system_seek");

        public static readonly Column<SqlDateTime> LastSystemUpdate = new("last_system_update");

        public static readonly Column<SqlDateTime> LastUserLookup = new("last_user_lookup");

        public static readonly Column<SqlDateTime> LastUserScan = new("last_user_scan");

        public static readonly Column<SqlDateTime> LastUserSeek = new("last_user_seek");

        public static readonly Column<SqlDateTime> LastUserUpdate = new("last_user_update");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlBigInt> SystemLookups = new("system_lookups");

        public static readonly Column<SqlBigInt> SystemScans = new("system_scans");

        public static readonly Column<SqlBigInt> SystemSeeks = new("system_seeks");

        public static readonly Column<SqlBigInt> SystemUpdates = new("system_updates");

        public static readonly Column<SqlBigInt> UserLookups = new("user_lookups");

        public static readonly Column<SqlBigInt> UserScans = new("user_scans");

        public static readonly Column<SqlBigInt> UserSeeks = new("user_seeks");

        public static readonly Column<SqlBigInt> UserUpdates = new("user_updates");
    }
}
