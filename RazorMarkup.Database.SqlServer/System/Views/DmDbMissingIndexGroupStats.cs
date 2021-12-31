using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbMissingIndexGroupStats
    {
        public static readonly ViewName ViewName = new("sys.dm_db_missing_index_group_stats");

        public static readonly Column<SqlFloat> AvgSystemImpact = new("avg_system_impact");

        public static readonly Column<SqlFloat> AvgTotalSystemCost = new("avg_total_system_cost");

        public static readonly Column<SqlFloat> AvgTotalUserCost = new("avg_total_user_cost");

        public static readonly Column<SqlFloat> AvgUserImpact = new("avg_user_impact");

        public static readonly Column<SqlInt> GroupHandle = new("group_handle");

        public static readonly Column<SqlDateTime> LastSystemScan = new("last_system_scan");

        public static readonly Column<SqlDateTime> LastSystemSeek = new("last_system_seek");

        public static readonly Column<SqlDateTime> LastUserScan = new("last_user_scan");

        public static readonly Column<SqlDateTime> LastUserSeek = new("last_user_seek");

        public static readonly Column<SqlBigInt> SystemScans = new("system_scans");

        public static readonly Column<SqlBigInt> SystemSeeks = new("system_seeks");

        public static readonly Column<SqlBigInt> UniqueCompiles = new("unique_compiles");

        public static readonly Column<SqlBigInt> UserScans = new("user_scans");

        public static readonly Column<SqlBigInt> UserSeeks = new("user_seeks");
    }
}
