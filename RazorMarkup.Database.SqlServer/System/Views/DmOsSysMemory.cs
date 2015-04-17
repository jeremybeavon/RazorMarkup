using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsSysMemory
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_sys_memory");
        
        public static readonly Column<SqlBigInt> AvailablePageFileKb = new Column<SqlBigInt>("available_page_file_kb");
        
        public static readonly Column<SqlBigInt> AvailablePhysicalMemoryKb = new Column<SqlBigInt>("available_physical_memory_kb");
        
        public static readonly Column<SqlBigInt> KernelNonpagedPoolKb = new Column<SqlBigInt>("kernel_nonpaged_pool_kb");
        
        public static readonly Column<SqlBigInt> KernelPagedPoolKb = new Column<SqlBigInt>("kernel_paged_pool_kb");
        
        public static readonly Column<SqlBigInt> SystemCacheKb = new Column<SqlBigInt>("system_cache_kb");
        
        public static readonly Column<SqlBit> SystemHighMemorySignalState = new Column<SqlBit>("system_high_memory_signal_state");
        
        public static readonly Column<SqlBit> SystemLowMemorySignalState = new Column<SqlBit>("system_low_memory_signal_state");
        
        public static readonly Column<SqlNVarchar> SystemMemoryStateDesc = new Column<SqlNVarchar>("system_memory_state_desc");
        
        public static readonly Column<SqlBigInt> TotalPageFileKb = new Column<SqlBigInt>("total_page_file_kb");
        
        public static readonly Column<SqlBigInt> TotalPhysicalMemoryKb = new Column<SqlBigInt>("total_physical_memory_kb");
    }
}
