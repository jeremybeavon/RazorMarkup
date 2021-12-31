using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsThreads
    {
        public static readonly ViewName ViewName = new("sys.dm_os_threads");

        public static readonly Column<SqlBigInt> Affinity = new("affinity");

        public static readonly Column<SqlDateTime> CreationTime = new("creation_time");

        public static readonly Column<SqlVarbinary> EventHandle = new("event_handle");

        public static readonly Column<SqlVarbinary> FiberContextAddress = new("fiber_context_address");

        public static readonly Column<SqlVarbinary> FiberData = new("fiber_data");

        public static readonly Column<SqlVarbinary> InstructionAddress = new("instruction_address");

        public static readonly Column<SqlInt> IsImpersonating = new("is_impersonating");

        public static readonly Column<SqlInt> IsWaitingOnLoaderLock = new("is_waiting_on_loader_lock");

        public static readonly Column<SqlBigInt> KernelTime = new("kernel_time");

        public static readonly Column<SqlInt> Locale = new("locale");

        public static readonly Column<SqlInt> OsThreadId = new("os_thread_id");

        public static readonly Column<SqlInt> Priority = new("priority");

        public static readonly Column<SqlSmallInt> ProcessorGroup = new("processor_group");

        public static readonly Column<SqlVarbinary> SchedulerAddress = new("scheduler_address");

        public static readonly Column<SqlVarbinary> SelfAddress = new("self_address");

        public static readonly Column<SqlVarbinary> StackBaseAddress = new("stack_base_address");

        public static readonly Column<SqlInt> StackBytesCommitted = new("stack_bytes_committed");

        public static readonly Column<SqlInt> StackBytesUsed = new("stack_bytes_used");

        public static readonly Column<SqlVarbinary> StackEndAddress = new("stack_end_address");

        public static readonly Column<SqlBit> StartedBySqlservr = new("started_by_sqlservr");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlVarbinary> ThreadAddress = new("thread_address");

        public static readonly Column<SqlVarbinary> ThreadHandle = new("thread_handle");

        public static readonly Column<SqlVarbinary> Token = new("token");

        public static readonly Column<SqlBigInt> UsermodeTime = new("usermode_time");

        public static readonly Column<SqlVarbinary> WorkerAddress = new("worker_address");
    }
}
