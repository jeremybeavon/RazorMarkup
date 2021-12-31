using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryClerks
    {
        public static readonly ViewName ViewName = new("sys.dm_os_memory_clerks");

        public static readonly Column<SqlBigInt> AweAllocatedKb = new("awe_allocated_kb");

        public static readonly Column<SqlVarbinary> HostAddress = new("host_address");

        public static readonly Column<SqlVarbinary> MemoryClerkAddress = new("memory_clerk_address");

        public static readonly Column<SqlSmallInt> MemoryNodeId = new("memory_node_id");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlVarbinary> PageAllocatorAddress = new("page_allocator_address");

        public static readonly Column<SqlBigInt> PageSizeInBytes = new("page_size_in_bytes");

        public static readonly Column<SqlBigInt> PagesKb = new("pages_kb");

        public static readonly Column<SqlBigInt> SharedMemoryCommittedKb = new("shared_memory_committed_kb");

        public static readonly Column<SqlBigInt> SharedMemoryReservedKb = new("shared_memory_reserved_kb");

        public static readonly Column<SqlNVarchar> Type = new("type");

        public static readonly Column<SqlBigInt> VirtualMemoryCommittedKb = new("virtual_memory_committed_kb");

        public static readonly Column<SqlBigInt> VirtualMemoryReservedKb = new("virtual_memory_reserved_kb");
    }
}
