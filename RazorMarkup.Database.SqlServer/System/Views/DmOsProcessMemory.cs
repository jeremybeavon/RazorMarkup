using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsProcessMemory
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_process_memory");
        
        public static readonly Column<SqlBigInt> AvailableCommitLimitKb = new Column<SqlBigInt>("available_commit_limit_kb");
        
        public static readonly Column<SqlBigInt> LargePageAllocationsKb = new Column<SqlBigInt>("large_page_allocations_kb");
        
        public static readonly Column<SqlBigInt> LockedPageAllocationsKb = new Column<SqlBigInt>("locked_page_allocations_kb");
        
        public static readonly Column<SqlInt> MemoryUtilizationPercentage = new Column<SqlInt>("memory_utilization_percentage");
        
        public static readonly Column<SqlBigInt> PageFaultCount = new Column<SqlBigInt>("page_fault_count");
        
        public static readonly Column<SqlBigInt> PhysicalMemoryInUseKb = new Column<SqlBigInt>("physical_memory_in_use_kb");
        
        public static readonly Column<SqlBit> ProcessPhysicalMemoryLow = new Column<SqlBit>("process_physical_memory_low");
        
        public static readonly Column<SqlBit> ProcessVirtualMemoryLow = new Column<SqlBit>("process_virtual_memory_low");
        
        public static readonly Column<SqlBigInt> TotalVirtualAddressSpaceKb = new Column<SqlBigInt>("total_virtual_address_space_kb");
        
        public static readonly Column<SqlBigInt> VirtualAddressSpaceAvailableKb = new Column<SqlBigInt>("virtual_address_space_available_kb");
        
        public static readonly Column<SqlBigInt> VirtualAddressSpaceCommittedKb = new Column<SqlBigInt>("virtual_address_space_committed_kb");
        
        public static readonly Column<SqlBigInt> VirtualAddressSpaceReservedKb = new Column<SqlBigInt>("virtual_address_space_reserved_kb");
    }
}
