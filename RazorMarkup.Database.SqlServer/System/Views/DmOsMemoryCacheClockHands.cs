using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryCacheClockHands
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_memory_cache_clock_hands");
        
        public static readonly Column<SqlVarbinary> CacheAddress = new Column<SqlVarbinary>("cache_address");
        
        public static readonly Column<SqlNVarchar> ClockHand = new Column<SqlNVarchar>("clock_hand");
        
        public static readonly Column<SqlNVarchar> ClockStatus = new Column<SqlNVarchar>("clock_status");
        
        public static readonly Column<SqlBigInt> LastRoundStartTime = new Column<SqlBigInt>("last_round_start_time");
        
        public static readonly Column<SqlBigInt> LastTickTime = new Column<SqlBigInt>("last_tick_time");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlBigInt> RemovedAllRoundsCount = new Column<SqlBigInt>("removed_all_rounds_count");
        
        public static readonly Column<SqlBigInt> RemovedLastRoundCount = new Column<SqlBigInt>("removed_last_round_count");
        
        public static readonly Column<SqlBigInt> RoundStartTime = new Column<SqlBigInt>("round_start_time");
        
        public static readonly Column<SqlBigInt> RoundsCount = new Column<SqlBigInt>("rounds_count");
        
        public static readonly Column<SqlNVarchar> Type = new Column<SqlNVarchar>("type");
        
        public static readonly Column<SqlBigInt> UpdatedLastRoundCount = new Column<SqlBigInt>("updated_last_round_count");
    }
}
