using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryCacheEntries
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_memory_cache_entries");
        
        public static readonly Column<SqlFloat> AverageTimeBetweenUses = new Column<SqlFloat>("average_time_between_uses");
        
        public static readonly Column<SqlVarbinary> CacheAddress = new Column<SqlVarbinary>("cache_address");
        
        public static readonly Column<SqlInt> ContextSwitchesCount = new Column<SqlInt>("context_switches_count");
        
        public static readonly Column<SqlInt> CurrentCost = new Column<SqlInt>("current_cost");
        
        public static readonly Column<SqlInt> DiskIosCount = new Column<SqlInt>("disk_ios_count");
        
        public static readonly Column<SqlVarbinary> EntryAddress = new Column<SqlVarbinary>("entry_address");
        
        public static readonly Column<SqlNVarchar> EntryData = new Column<SqlNVarchar>("entry_data");
        
        public static readonly Column<SqlVarbinary> EntryDataAddress = new Column<SqlVarbinary>("entry_data_address");
        
        public static readonly Column<SqlInt> InUseCount = new Column<SqlInt>("in_use_count");
        
        public static readonly Column<SqlBit> IsDirty = new Column<SqlBit>("is_dirty");
        
        public static readonly Column<SqlVarbinary> MemoryObjectAddress = new Column<SqlVarbinary>("memory_object_address");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlInt> OriginalCost = new Column<SqlInt>("original_cost");
        
        public static readonly Column<SqlBigInt> PagesKb = new Column<SqlBigInt>("pages_kb");
        
        public static readonly Column<SqlInt> PoolId = new Column<SqlInt>("pool_id");
        
        public static readonly Column<SqlFloat> ProbabilityOfReuse = new Column<SqlFloat>("probability_of_reuse");
        
        public static readonly Column<SqlFloat> TimeSinceLastUse = new Column<SqlFloat>("time_since_last_use");
        
        public static readonly Column<SqlFloat> TimeToGenerate = new Column<SqlFloat>("time_to_generate");
        
        public static readonly Column<SqlNVarchar> Type = new Column<SqlNVarchar>("type");
        
        public static readonly Column<SqlBigInt> UseCount = new Column<SqlBigInt>("use_count");
        
        public static readonly Column<SqlFloat> Value = new Column<SqlFloat>("value");
    }
}
