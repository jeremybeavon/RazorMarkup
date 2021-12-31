using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsProcessMemory
    {
        public static readonly ViewName ViewName = new("sys.dm_os_process_memory");

        public static readonly Column<SqlBigInt> AvailableCommitLimitKb = new("available_commit_limit_kb");

        public static readonly Column<SqlBigInt> LargePageAllocationsKb = new("large_page_allocations_kb");

        public static readonly Column<SqlBigInt> LockedPageAllocationsKb = new("locked_page_allocations_kb");

        public static readonly Column<SqlInt> MemoryUtilizationPercentage = new("memory_utilization_percentage");

        public static readonly Column<SqlBigInt> PageFaultCount = new("page_fault_count");

        public static readonly Column<SqlBigInt> PhysicalMemoryInUseKb = new("physical_memory_in_use_kb");

        public static readonly Column<SqlBit> ProcessPhysicalMemoryLow = new("process_physical_memory_low");

        public static readonly Column<SqlBit> ProcessVirtualMemoryLow = new("process_virtual_memory_low");

        public static readonly Column<SqlBigInt> TotalVirtualAddressSpaceKb = new("total_virtual_address_space_kb");

        public static readonly Column<SqlBigInt> VirtualAddressSpaceAvailableKb = new("virtual_address_space_available_kb");

        public static readonly Column<SqlBigInt> VirtualAddressSpaceCommittedKb = new("virtual_address_space_committed_kb");

        public static readonly Column<SqlBigInt> VirtualAddressSpaceReservedKb = new("virtual_address_space_reserved_kb");
    }
}
