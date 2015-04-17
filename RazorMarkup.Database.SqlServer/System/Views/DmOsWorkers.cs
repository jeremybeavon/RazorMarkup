using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsWorkers
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_workers");
        
        public static readonly Column<SqlBigInt> Affinity = new Column<SqlBigInt>("affinity");
        
        public static readonly Column<SqlInt> BoostCount = new Column<SqlInt>("boost_count");
        
        public static readonly Column<SqlInt> ContextSwitchCount = new Column<SqlInt>("context_switch_count");
        
        public static readonly Column<SqlBigInt> EndQuantum = new Column<SqlBigInt>("end_quantum");
        
        public static readonly Column<SqlVarbinary> ExceptionAddress = new Column<SqlVarbinary>("exception_address");
        
        public static readonly Column<SqlInt> ExceptionNum = new Column<SqlInt>("exception_num");
        
        public static readonly Column<SqlInt> ExceptionSeverity = new Column<SqlInt>("exception_severity");
        
        public static readonly Column<SqlVarbinary> FiberAddress = new Column<SqlVarbinary>("fiber_address");
        
        public static readonly Column<SqlBit> IsFatalException = new Column<SqlBit>("is_fatal_exception");
        
        public static readonly Column<SqlBit> IsFiber = new Column<SqlBit>("is_fiber");
        
        public static readonly Column<SqlBit> IsInCcException = new Column<SqlBit>("is_in_cc_exception");
        
        public static readonly Column<SqlBit> IsInPollingIoCompletionRoutine = new Column<SqlBit>("is_in_polling_io_completion_routine");
        
        public static readonly Column<SqlBit> IsInsideCatch = new Column<SqlBit>("is_inside_catch");
        
        public static readonly Column<SqlBit> IsPreemptive = new Column<SqlBit>("is_preemptive");
        
        public static readonly Column<SqlBit> IsSick = new Column<SqlBit>("is_sick");
        
        public static readonly Column<SqlNVarchar> LastWaitType = new Column<SqlNVarchar>("last_wait_type");
        
        public static readonly Column<SqlBigInt> MaxQuantum = new Column<SqlBigInt>("max_quantum");
        
        public static readonly Column<SqlVarbinary> MemoryObjectAddress = new Column<SqlVarbinary>("memory_object_address");
        
        public static readonly Column<SqlInt> PendingIoByteAverage = new Column<SqlInt>("pending_io_byte_average");
        
        public static readonly Column<SqlBigInt> PendingIoByteCount = new Column<SqlBigInt>("pending_io_byte_count");
        
        public static readonly Column<SqlInt> PendingIoCount = new Column<SqlInt>("pending_io_count");
        
        public static readonly Column<SqlSmallInt> ProcessorGroup = new Column<SqlSmallInt>("processor_group");
        
        public static readonly Column<SqlBigInt> QuantumUsed = new Column<SqlBigInt>("quantum_used");
        
        public static readonly Column<SqlInt> ReturnCode = new Column<SqlInt>("return_code");
        
        public static readonly Column<SqlVarbinary> SchedulerAddress = new Column<SqlVarbinary>("scheduler_address");
        
        public static readonly Column<SqlVarbinary> SignalWorkerAddress = new Column<SqlVarbinary>("signal_worker_address");
        
        public static readonly Column<SqlBigInt> StartQuantum = new Column<SqlBigInt>("start_quantum");
        
        public static readonly Column<SqlNVarchar> State = new Column<SqlNVarchar>("state");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlVarbinary> TaskAddress = new Column<SqlVarbinary>("task_address");
        
        public static readonly Column<SqlBigInt> TaskBoundMsTicks = new Column<SqlBigInt>("task_bound_ms_ticks");
        
        public static readonly Column<SqlInt> TasksProcessedCount = new Column<SqlInt>("tasks_processed_count");
        
        public static readonly Column<SqlVarbinary> ThreadAddress = new Column<SqlVarbinary>("thread_address");
        
        public static readonly Column<SqlBigInt> WaitResumedMsTicks = new Column<SqlBigInt>("wait_resumed_ms_ticks");
        
        public static readonly Column<SqlBigInt> WaitStartedMsTicks = new Column<SqlBigInt>("wait_started_ms_ticks");
        
        public static readonly Column<SqlVarbinary> WorkerAddress = new Column<SqlVarbinary>("worker_address");
        
        public static readonly Column<SqlBigInt> WorkerCreatedMsTicks = new Column<SqlBigInt>("worker_created_ms_ticks");
    }
}
