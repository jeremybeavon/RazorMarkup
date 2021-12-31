using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryNodes
    {
        public static readonly ViewName ViewName = new("sys.dm_os_memory_nodes");

        public static readonly Column<SqlBigInt> CpuAffinityMask = new("cpu_affinity_mask");

        public static readonly Column<SqlBigInt> ForeignCommittedKb = new("foreign_committed_kb");

        public static readonly Column<SqlBigInt> LockedPageAllocationsKb = new("locked_page_allocations_kb");

        public static readonly Column<SqlSmallInt> MemoryNodeId = new("memory_node_id");

        public static readonly Column<SqlBigInt> OnlineSchedulerMask = new("online_scheduler_mask");

        public static readonly Column<SqlBigInt> PagesKb = new("pages_kb");

        public static readonly Column<SqlSmallInt> ProcessorGroup = new("processor_group");

        public static readonly Column<SqlBigInt> SharedMemoryCommittedKb = new("shared_memory_committed_kb");

        public static readonly Column<SqlBigInt> SharedMemoryReservedKb = new("shared_memory_reserved_kb");

        public static readonly Column<SqlBigInt> VirtualAddressSpaceCommittedKb = new("virtual_address_space_committed_kb");

        public static readonly Column<SqlBigInt> VirtualAddressSpaceReservedKb = new("virtual_address_space_reserved_kb");
    }
}
