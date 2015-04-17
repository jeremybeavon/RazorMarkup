using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsSysInfo
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_sys_info");
        
        public static readonly Column<SqlInt> AffinityType = new Column<SqlInt>("affinity_type");
        
        public static readonly Column<SqlNVarchar> AffinityTypeDesc = new Column<SqlNVarchar>("affinity_type_desc");
        
        public static readonly Column<SqlBigInt> CommittedKb = new Column<SqlBigInt>("committed_kb");
        
        public static readonly Column<SqlBigInt> CommittedTargetKb = new Column<SqlBigInt>("committed_target_kb");
        
        public static readonly Column<SqlInt> CpuCount = new Column<SqlInt>("cpu_count");
        
        public static readonly Column<SqlBigInt> CpuTicks = new Column<SqlBigInt>("cpu_ticks");
        
        public static readonly Column<SqlInt> DeadlockMonitorSerialNumber = new Column<SqlInt>("deadlock_monitor_serial_number");
        
        public static readonly Column<SqlInt> HyperthreadRatio = new Column<SqlInt>("hyperthread_ratio");
        
        public static readonly Column<SqlInt> MaxWorkersCount = new Column<SqlInt>("max_workers_count");
        
        public static readonly Column<SqlBigInt> MsTicks = new Column<SqlBigInt>("ms_ticks");
        
        public static readonly Column<SqlInt> OsErrorMode = new Column<SqlInt>("os_error_mode");
        
        public static readonly Column<SqlInt> OsPriorityClass = new Column<SqlInt>("os_priority_class");
        
        public static readonly Column<SqlBigInt> OsQuantum = new Column<SqlBigInt>("os_quantum");
        
        public static readonly Column<SqlBigInt> PhysicalMemoryKb = new Column<SqlBigInt>("physical_memory_kb");
        
        public static readonly Column<SqlBigInt> ProcessKernelTimeMs = new Column<SqlBigInt>("process_kernel_time_ms");
        
        public static readonly Column<SqlBigInt> ProcessUserTimeMs = new Column<SqlBigInt>("process_user_time_ms");
        
        public static readonly Column<SqlInt> SchedulerCount = new Column<SqlInt>("scheduler_count");
        
        public static readonly Column<SqlInt> SchedulerTotalCount = new Column<SqlInt>("scheduler_total_count");
        
        public static readonly Column<SqlDateTime> SqlserverStartTime = new Column<SqlDateTime>("sqlserver_start_time");
        
        public static readonly Column<SqlBigInt> SqlserverStartTimeMsTicks = new Column<SqlBigInt>("sqlserver_start_time_ms_ticks");
        
        public static readonly Column<SqlInt> StackSizeInBytes = new Column<SqlInt>("stack_size_in_bytes");
        
        public static readonly Column<SqlInt> TimeSource = new Column<SqlInt>("time_source");
        
        public static readonly Column<SqlNVarchar> TimeSourceDesc = new Column<SqlNVarchar>("time_source_desc");
        
        public static readonly Column<SqlInt> VirtualMachineType = new Column<SqlInt>("virtual_machine_type");
        
        public static readonly Column<SqlNVarchar> VirtualMachineTypeDesc = new Column<SqlNVarchar>("virtual_machine_type_desc");
        
        public static readonly Column<SqlBigInt> VirtualMemoryKb = new Column<SqlBigInt>("virtual_memory_kb");
        
        public static readonly Column<SqlBigInt> VisibleTargetKb = new Column<SqlBigInt>("visible_target_kb");
    }
}
