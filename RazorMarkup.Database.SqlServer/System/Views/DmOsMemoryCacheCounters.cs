using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryCacheCounters
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_memory_cache_counters");
        
        public static readonly Column<SqlVarbinary> CacheAddress = new Column<SqlVarbinary>("cache_address");
        
        public static readonly Column<SqlBigInt> EntriesCount = new Column<SqlBigInt>("entries_count");
        
        public static readonly Column<SqlBigInt> EntriesInUseCount = new Column<SqlBigInt>("entries_in_use_count");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlBigInt> PagesInUseKb = new Column<SqlBigInt>("pages_in_use_kb");
        
        public static readonly Column<SqlBigInt> PagesKb = new Column<SqlBigInt>("pages_kb");
        
        public static readonly Column<SqlNVarchar> Type = new Column<SqlNVarchar>("type");
    }
}
