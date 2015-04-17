using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryClerks
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_memory_clerks");
        
        public static readonly Column<SqlBigInt> AweAllocatedKb = new Column<SqlBigInt>("awe_allocated_kb");
        
        public static readonly Column<SqlVarbinary> HostAddress = new Column<SqlVarbinary>("host_address");
        
        public static readonly Column<SqlVarbinary> MemoryClerkAddress = new Column<SqlVarbinary>("memory_clerk_address");
        
        public static readonly Column<SqlSmallInt> MemoryNodeId = new Column<SqlSmallInt>("memory_node_id");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlVarbinary> PageAllocatorAddress = new Column<SqlVarbinary>("page_allocator_address");
        
        public static readonly Column<SqlBigInt> PageSizeInBytes = new Column<SqlBigInt>("page_size_in_bytes");
        
        public static readonly Column<SqlBigInt> PagesKb = new Column<SqlBigInt>("pages_kb");
        
        public static readonly Column<SqlBigInt> SharedMemoryCommittedKb = new Column<SqlBigInt>("shared_memory_committed_kb");
        
        public static readonly Column<SqlBigInt> SharedMemoryReservedKb = new Column<SqlBigInt>("shared_memory_reserved_kb");
        
        public static readonly Column<SqlNVarchar> Type = new Column<SqlNVarchar>("type");
        
        public static readonly Column<SqlBigInt> VirtualMemoryCommittedKb = new Column<SqlBigInt>("virtual_memory_committed_kb");
        
        public static readonly Column<SqlBigInt> VirtualMemoryReservedKb = new Column<SqlBigInt>("virtual_memory_reserved_kb");
    }
}
