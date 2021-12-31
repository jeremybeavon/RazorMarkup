using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsWorkers
    {
        public static readonly ViewName ViewName = new("sys.dm_os_workers");

        public static readonly Column<SqlBigInt> Affinity = new("affinity");

        public static readonly Column<SqlInt> BoostCount = new("boost_count");

        public static readonly Column<SqlInt> ContextSwitchCount = new("context_switch_count");

        public static readonly Column<SqlBigInt> EndQuantum = new("end_quantum");

        public static readonly Column<SqlVarbinary> ExceptionAddress = new("exception_address");

        public static readonly Column<SqlInt> ExceptionNum = new("exception_num");

        public static readonly Column<SqlInt> ExceptionSeverity = new("exception_severity");

        public static readonly Column<SqlVarbinary> FiberAddress = new("fiber_address");

        public static readonly Column<SqlBit> IsFatalException = new("is_fatal_exception");

        public static readonly Column<SqlBit> IsFiber = new("is_fiber");

        public static readonly Column<SqlBit> IsInCcException = new("is_in_cc_exception");

        public static readonly Column<SqlBit> IsInPollingIoCompletionRoutine = new("is_in_polling_io_completion_routine");

        public static readonly Column<SqlBit> IsInsideCatch = new("is_inside_catch");

        public static readonly Column<SqlBit> IsPreemptive = new("is_preemptive");

        public static readonly Column<SqlBit> IsSick = new("is_sick");

        public static readonly Column<SqlNVarchar> LastWaitType = new("last_wait_type");

        public static readonly Column<SqlBigInt> MaxQuantum = new("max_quantum");

        public static readonly Column<SqlVarbinary> MemoryObjectAddress = new("memory_object_address");

        public static readonly Column<SqlInt> PendingIoByteAverage = new("pending_io_byte_average");

        public static readonly Column<SqlBigInt> PendingIoByteCount = new("pending_io_byte_count");

        public static readonly Column<SqlInt> PendingIoCount = new("pending_io_count");

        public static readonly Column<SqlSmallInt> ProcessorGroup = new("processor_group");

        public static readonly Column<SqlBigInt> QuantumUsed = new("quantum_used");

        public static readonly Column<SqlInt> ReturnCode = new("return_code");

        public static readonly Column<SqlVarbinary> SchedulerAddress = new("scheduler_address");

        public static readonly Column<SqlVarbinary> SignalWorkerAddress = new("signal_worker_address");

        public static readonly Column<SqlBigInt> StartQuantum = new("start_quantum");

        public static readonly Column<SqlNVarchar> State = new("state");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlVarbinary> TaskAddress = new("task_address");

        public static readonly Column<SqlBigInt> TaskBoundMsTicks = new("task_bound_ms_ticks");

        public static readonly Column<SqlInt> TasksProcessedCount = new("tasks_processed_count");

        public static readonly Column<SqlVarbinary> ThreadAddress = new("thread_address");

        public static readonly Column<SqlBigInt> WaitResumedMsTicks = new("wait_resumed_ms_ticks");

        public static readonly Column<SqlBigInt> WaitStartedMsTicks = new("wait_started_ms_ticks");

        public static readonly Column<SqlVarbinary> WorkerAddress = new("worker_address");

        public static readonly Column<SqlBigInt> WorkerCreatedMsTicks = new("worker_created_ms_ticks");
    }
}
