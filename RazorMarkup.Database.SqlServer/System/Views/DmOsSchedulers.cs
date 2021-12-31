using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsSchedulers
    {
        public static readonly ViewName ViewName = new("sys.dm_os_schedulers");

        public static readonly Column<SqlVarbinary> ActiveWorkerAddress = new("active_worker_address");

        public static readonly Column<SqlInt> ActiveWorkersCount = new("active_workers_count");

        public static readonly Column<SqlInt> ContextSwitchesCount = new("context_switches_count");

        public static readonly Column<SqlInt> CpuId = new("cpu_id");

        public static readonly Column<SqlInt> CurrentTasksCount = new("current_tasks_count");

        public static readonly Column<SqlInt> CurrentWorkersCount = new("current_workers_count");

        public static readonly Column<SqlBit> FailedToCreateWorker = new("failed_to_create_worker");

        public static readonly Column<SqlInt> IdleSwitchesCount = new("idle_switches_count");

        public static readonly Column<SqlBit> IsIdle = new("is_idle");

        public static readonly Column<SqlBit> IsOnline = new("is_online");

        public static readonly Column<SqlBigInt> LastTimerActivity = new("last_timer_activity");

        public static readonly Column<SqlInt> LoadFactor = new("load_factor");

        public static readonly Column<SqlVarbinary> MemoryObjectAddress = new("memory_object_address");

        public static readonly Column<SqlInt> ParentNodeId = new("parent_node_id");

        public static readonly Column<SqlInt> PendingDiskIoCount = new("pending_disk_io_count");

        public static readonly Column<SqlInt> PreemptiveSwitchesCount = new("preemptive_switches_count");

        public static readonly Column<SqlBigInt> QuantumLengthUs = new("quantum_length_us");

        public static readonly Column<SqlInt> RunnableTasksCount = new("runnable_tasks_count");

        public static readonly Column<SqlVarbinary> SchedulerAddress = new("scheduler_address");

        public static readonly Column<SqlInt> SchedulerId = new("scheduler_id");

        public static readonly Column<SqlNVarchar> Status = new("status");

        public static readonly Column<SqlVarbinary> TaskMemoryObjectAddress = new("task_memory_object_address");

        public static readonly Column<SqlBigInt> WorkQueueCount = new("work_queue_count");

        public static readonly Column<SqlInt> YieldCount = new("yield_count");
    }
}
