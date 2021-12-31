using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsSysInfo
    {
        public static readonly ViewName ViewName = new("sys.dm_os_sys_info");

        public static readonly Column<SqlInt> AffinityType = new("affinity_type");

        public static readonly Column<SqlNVarchar> AffinityTypeDesc = new("affinity_type_desc");

        public static readonly Column<SqlBigInt> CommittedKb = new("committed_kb");

        public static readonly Column<SqlBigInt> CommittedTargetKb = new("committed_target_kb");

        public static readonly Column<SqlInt> CpuCount = new("cpu_count");

        public static readonly Column<SqlBigInt> CpuTicks = new("cpu_ticks");

        public static readonly Column<SqlInt> DeadlockMonitorSerialNumber = new("deadlock_monitor_serial_number");

        public static readonly Column<SqlInt> HyperthreadRatio = new("hyperthread_ratio");

        public static readonly Column<SqlInt> MaxWorkersCount = new("max_workers_count");

        public static readonly Column<SqlBigInt> MsTicks = new("ms_ticks");

        public static readonly Column<SqlInt> OsErrorMode = new("os_error_mode");

        public static readonly Column<SqlInt> OsPriorityClass = new("os_priority_class");

        public static readonly Column<SqlBigInt> OsQuantum = new("os_quantum");

        public static readonly Column<SqlBigInt> PhysicalMemoryKb = new("physical_memory_kb");

        public static readonly Column<SqlBigInt> ProcessKernelTimeMs = new("process_kernel_time_ms");

        public static readonly Column<SqlBigInt> ProcessUserTimeMs = new("process_user_time_ms");

        public static readonly Column<SqlInt> SchedulerCount = new("scheduler_count");

        public static readonly Column<SqlInt> SchedulerTotalCount = new("scheduler_total_count");

        public static readonly Column<SqlDateTime> SqlserverStartTime = new("sqlserver_start_time");

        public static readonly Column<SqlBigInt> SqlserverStartTimeMsTicks = new("sqlserver_start_time_ms_ticks");

        public static readonly Column<SqlInt> StackSizeInBytes = new("stack_size_in_bytes");

        public static readonly Column<SqlInt> TimeSource = new("time_source");

        public static readonly Column<SqlNVarchar> TimeSourceDesc = new("time_source_desc");

        public static readonly Column<SqlInt> VirtualMachineType = new("virtual_machine_type");

        public static readonly Column<SqlNVarchar> VirtualMachineTypeDesc = new("virtual_machine_type_desc");

        public static readonly Column<SqlBigInt> VirtualMemoryKb = new("virtual_memory_kb");

        public static readonly Column<SqlBigInt> VisibleTargetKb = new("visible_target_kb");
    }
}
