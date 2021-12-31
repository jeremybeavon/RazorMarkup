using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryCacheEntries
    {
        public static readonly ViewName ViewName = new("sys.dm_os_memory_cache_entries");

        public static readonly Column<SqlFloat> AverageTimeBetweenUses = new("average_time_between_uses");

        public static readonly Column<SqlVarbinary> CacheAddress = new("cache_address");

        public static readonly Column<SqlInt> ContextSwitchesCount = new("context_switches_count");

        public static readonly Column<SqlInt> CurrentCost = new("current_cost");

        public static readonly Column<SqlInt> DiskIosCount = new("disk_ios_count");

        public static readonly Column<SqlVarbinary> EntryAddress = new("entry_address");

        public static readonly Column<SqlNVarchar> EntryData = new("entry_data");

        public static readonly Column<SqlVarbinary> EntryDataAddress = new("entry_data_address");

        public static readonly Column<SqlInt> InUseCount = new("in_use_count");

        public static readonly Column<SqlBit> IsDirty = new("is_dirty");

        public static readonly Column<SqlVarbinary> MemoryObjectAddress = new("memory_object_address");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlInt> OriginalCost = new("original_cost");

        public static readonly Column<SqlBigInt> PagesKb = new("pages_kb");

        public static readonly Column<SqlInt> PoolId = new("pool_id");

        public static readonly Column<SqlFloat> ProbabilityOfReuse = new("probability_of_reuse");

        public static readonly Column<SqlFloat> TimeSinceLastUse = new("time_since_last_use");

        public static readonly Column<SqlFloat> TimeToGenerate = new("time_to_generate");

        public static readonly Column<SqlNVarchar> Type = new("type");

        public static readonly Column<SqlBigInt> UseCount = new("use_count");

        public static readonly Column<SqlFloat> Value = new("value");
    }
}
