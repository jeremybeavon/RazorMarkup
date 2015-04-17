using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryPools
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_memory_pools");
        
        public static readonly Column<SqlBigInt> FreeEntriesCount = new Column<SqlBigInt>("free_entries_count");
        
        public static readonly Column<SqlBigInt> MaxFreeEntriesCount = new Column<SqlBigInt>("max_free_entries_count");
        
        public static readonly Column<SqlVarbinary> MemoryPoolAddress = new Column<SqlVarbinary>("memory_pool_address");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlInt> PoolId = new Column<SqlInt>("pool_id");
        
        public static readonly Column<SqlBigInt> RemovedInAllRoundsCount = new Column<SqlBigInt>("removed_in_all_rounds_count");
        
        public static readonly Column<SqlNVarchar> Type = new Column<SqlNVarchar>("type");
    }
}
