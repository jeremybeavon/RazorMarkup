using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryCacheCounters
    {
        public static readonly ViewName ViewName = new("sys.dm_os_memory_cache_counters");

        public static readonly Column<SqlVarbinary> CacheAddress = new("cache_address");

        public static readonly Column<SqlBigInt> EntriesCount = new("entries_count");

        public static readonly Column<SqlBigInt> EntriesInUseCount = new("entries_in_use_count");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlBigInt> PagesInUseKb = new("pages_in_use_kb");

        public static readonly Column<SqlBigInt> PagesKb = new("pages_kb");

        public static readonly Column<SqlNVarchar> Type = new("type");
    }
}
