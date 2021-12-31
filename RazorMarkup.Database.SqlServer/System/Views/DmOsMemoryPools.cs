using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryPools
    {
        public static readonly ViewName ViewName = new("sys.dm_os_memory_pools");

        public static readonly Column<SqlBigInt> FreeEntriesCount = new("free_entries_count");

        public static readonly Column<SqlBigInt> MaxFreeEntriesCount = new("max_free_entries_count");

        public static readonly Column<SqlVarbinary> MemoryPoolAddress = new("memory_pool_address");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlInt> PoolId = new("pool_id");

        public static readonly Column<SqlBigInt> RemovedInAllRoundsCount = new("removed_in_all_rounds_count");

        public static readonly Column<SqlNVarchar> Type = new("type");
    }
}
