using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbIndexUsageStats
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_db_index_usage_stats");
        
        public static readonly Column<SqlSmallInt> DatabaseId = new Column<SqlSmallInt>("database_id");
        
        public static readonly Column<SqlInt> IndexId = new Column<SqlInt>("index_id");
        
        public static readonly Column<SqlDateTime> LastSystemLookup = new Column<SqlDateTime>("last_system_lookup");
        
        public static readonly Column<SqlDateTime> LastSystemScan = new Column<SqlDateTime>("last_system_scan");
        
        public static readonly Column<SqlDateTime> LastSystemSeek = new Column<SqlDateTime>("last_system_seek");
        
        public static readonly Column<SqlDateTime> LastSystemUpdate = new Column<SqlDateTime>("last_system_update");
        
        public static readonly Column<SqlDateTime> LastUserLookup = new Column<SqlDateTime>("last_user_lookup");
        
        public static readonly Column<SqlDateTime> LastUserScan = new Column<SqlDateTime>("last_user_scan");
        
        public static readonly Column<SqlDateTime> LastUserSeek = new Column<SqlDateTime>("last_user_seek");
        
        public static readonly Column<SqlDateTime> LastUserUpdate = new Column<SqlDateTime>("last_user_update");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlBigInt> SystemLookups = new Column<SqlBigInt>("system_lookups");
        
        public static readonly Column<SqlBigInt> SystemScans = new Column<SqlBigInt>("system_scans");
        
        public static readonly Column<SqlBigInt> SystemSeeks = new Column<SqlBigInt>("system_seeks");
        
        public static readonly Column<SqlBigInt> SystemUpdates = new Column<SqlBigInt>("system_updates");
        
        public static readonly Column<SqlBigInt> UserLookups = new Column<SqlBigInt>("user_lookups");
        
        public static readonly Column<SqlBigInt> UserScans = new Column<SqlBigInt>("user_scans");
        
        public static readonly Column<SqlBigInt> UserSeeks = new Column<SqlBigInt>("user_seeks");
        
        public static readonly Column<SqlBigInt> UserUpdates = new Column<SqlBigInt>("user_updates");
    }
}
