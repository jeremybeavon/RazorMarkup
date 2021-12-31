using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsSysMemory
    {
        public static readonly ViewName ViewName = new("sys.dm_os_sys_memory");

        public static readonly Column<SqlBigInt> AvailablePageFileKb = new("available_page_file_kb");

        public static readonly Column<SqlBigInt> AvailablePhysicalMemoryKb = new("available_physical_memory_kb");

        public static readonly Column<SqlBigInt> KernelNonpagedPoolKb = new("kernel_nonpaged_pool_kb");

        public static readonly Column<SqlBigInt> KernelPagedPoolKb = new("kernel_paged_pool_kb");

        public static readonly Column<SqlBigInt> SystemCacheKb = new("system_cache_kb");

        public static readonly Column<SqlBit> SystemHighMemorySignalState = new("system_high_memory_signal_state");

        public static readonly Column<SqlBit> SystemLowMemorySignalState = new("system_low_memory_signal_state");

        public static readonly Column<SqlNVarchar> SystemMemoryStateDesc = new("system_memory_state_desc");

        public static readonly Column<SqlBigInt> TotalPageFileKb = new("total_page_file_kb");

        public static readonly Column<SqlBigInt> TotalPhysicalMemoryKb = new("total_physical_memory_kb");
    }
}
