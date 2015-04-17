using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbMissingIndexGroupStats
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_db_missing_index_group_stats");
        
        public static readonly Column<SqlFloat> AvgSystemImpact = new Column<SqlFloat>("avg_system_impact");
        
        public static readonly Column<SqlFloat> AvgTotalSystemCost = new Column<SqlFloat>("avg_total_system_cost");
        
        public static readonly Column<SqlFloat> AvgTotalUserCost = new Column<SqlFloat>("avg_total_user_cost");
        
        public static readonly Column<SqlFloat> AvgUserImpact = new Column<SqlFloat>("avg_user_impact");
        
        public static readonly Column<SqlInt> GroupHandle = new Column<SqlInt>("group_handle");
        
        public static readonly Column<SqlDateTime> LastSystemScan = new Column<SqlDateTime>("last_system_scan");
        
        public static readonly Column<SqlDateTime> LastSystemSeek = new Column<SqlDateTime>("last_system_seek");
        
        public static readonly Column<SqlDateTime> LastUserScan = new Column<SqlDateTime>("last_user_scan");
        
        public static readonly Column<SqlDateTime> LastUserSeek = new Column<SqlDateTime>("last_user_seek");
        
        public static readonly Column<SqlBigInt> SystemScans = new Column<SqlBigInt>("system_scans");
        
        public static readonly Column<SqlBigInt> SystemSeeks = new Column<SqlBigInt>("system_seeks");
        
        public static readonly Column<SqlBigInt> UniqueCompiles = new Column<SqlBigInt>("unique_compiles");
        
        public static readonly Column<SqlBigInt> UserScans = new Column<SqlBigInt>("user_scans");
        
        public static readonly Column<SqlBigInt> UserSeeks = new Column<SqlBigInt>("user_seeks");
    }
}
