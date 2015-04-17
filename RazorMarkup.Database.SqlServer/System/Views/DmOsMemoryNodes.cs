using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryNodes
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_memory_nodes");
        
        public static readonly Column<SqlBigInt> CpuAffinityMask = new Column<SqlBigInt>("cpu_affinity_mask");
        
        public static readonly Column<SqlBigInt> ForeignCommittedKb = new Column<SqlBigInt>("foreign_committed_kb");
        
        public static readonly Column<SqlBigInt> LockedPageAllocationsKb = new Column<SqlBigInt>("locked_page_allocations_kb");
        
        public static readonly Column<SqlSmallInt> MemoryNodeId = new Column<SqlSmallInt>("memory_node_id");
        
        public static readonly Column<SqlBigInt> OnlineSchedulerMask = new Column<SqlBigInt>("online_scheduler_mask");
        
        public static readonly Column<SqlBigInt> PagesKb = new Column<SqlBigInt>("pages_kb");
        
        public static readonly Column<SqlSmallInt> ProcessorGroup = new Column<SqlSmallInt>("processor_group");
        
        public static readonly Column<SqlBigInt> SharedMemoryCommittedKb = new Column<SqlBigInt>("shared_memory_committed_kb");
        
        public static readonly Column<SqlBigInt> SharedMemoryReservedKb = new Column<SqlBigInt>("shared_memory_reserved_kb");
        
        public static readonly Column<SqlBigInt> VirtualAddressSpaceCommittedKb = new Column<SqlBigInt>("virtual_address_space_committed_kb");
        
        public static readonly Column<SqlBigInt> VirtualAddressSpaceReservedKb = new Column<SqlBigInt>("virtual_address_space_reserved_kb");
    }
}
