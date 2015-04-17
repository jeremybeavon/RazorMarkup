using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsSchedulers
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_schedulers");
        
        public static readonly Column<SqlVarbinary> ActiveWorkerAddress = new Column<SqlVarbinary>("active_worker_address");
        
        public static readonly Column<SqlInt> ActiveWorkersCount = new Column<SqlInt>("active_workers_count");
        
        public static readonly Column<SqlInt> ContextSwitchesCount = new Column<SqlInt>("context_switches_count");
        
        public static readonly Column<SqlInt> CpuId = new Column<SqlInt>("cpu_id");
        
        public static readonly Column<SqlInt> CurrentTasksCount = new Column<SqlInt>("current_tasks_count");
        
        public static readonly Column<SqlInt> CurrentWorkersCount = new Column<SqlInt>("current_workers_count");
        
        public static readonly Column<SqlBit> FailedToCreateWorker = new Column<SqlBit>("failed_to_create_worker");
        
        public static readonly Column<SqlInt> IdleSwitchesCount = new Column<SqlInt>("idle_switches_count");
        
        public static readonly Column<SqlBit> IsIdle = new Column<SqlBit>("is_idle");
        
        public static readonly Column<SqlBit> IsOnline = new Column<SqlBit>("is_online");
        
        public static readonly Column<SqlBigInt> LastTimerActivity = new Column<SqlBigInt>("last_timer_activity");
        
        public static readonly Column<SqlInt> LoadFactor = new Column<SqlInt>("load_factor");
        
        public static readonly Column<SqlVarbinary> MemoryObjectAddress = new Column<SqlVarbinary>("memory_object_address");
        
        public static readonly Column<SqlInt> ParentNodeId = new Column<SqlInt>("parent_node_id");
        
        public static readonly Column<SqlInt> PendingDiskIoCount = new Column<SqlInt>("pending_disk_io_count");
        
        public static readonly Column<SqlInt> PreemptiveSwitchesCount = new Column<SqlInt>("preemptive_switches_count");
        
        public static readonly Column<SqlBigInt> QuantumLengthUs = new Column<SqlBigInt>("quantum_length_us");
        
        public static readonly Column<SqlInt> RunnableTasksCount = new Column<SqlInt>("runnable_tasks_count");
        
        public static readonly Column<SqlVarbinary> SchedulerAddress = new Column<SqlVarbinary>("scheduler_address");
        
        public static readonly Column<SqlInt> SchedulerId = new Column<SqlInt>("scheduler_id");
        
        public static readonly Column<SqlNVarchar> Status = new Column<SqlNVarchar>("status");
        
        public static readonly Column<SqlVarbinary> TaskMemoryObjectAddress = new Column<SqlVarbinary>("task_memory_object_address");
        
        public static readonly Column<SqlBigInt> WorkQueueCount = new Column<SqlBigInt>("work_queue_count");
        
        public static readonly Column<SqlInt> YieldCount = new Column<SqlInt>("yield_count");
    }
}
