using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsThreads
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_threads");
        
        public static readonly Column<SqlBigInt> Affinity = new Column<SqlBigInt>("affinity");
        
        public static readonly Column<SqlDateTime> CreationTime = new Column<SqlDateTime>("creation_time");
        
        public static readonly Column<SqlVarbinary> EventHandle = new Column<SqlVarbinary>("event_handle");
        
        public static readonly Column<SqlVarbinary> FiberContextAddress = new Column<SqlVarbinary>("fiber_context_address");
        
        public static readonly Column<SqlVarbinary> FiberData = new Column<SqlVarbinary>("fiber_data");
        
        public static readonly Column<SqlVarbinary> InstructionAddress = new Column<SqlVarbinary>("instruction_address");
        
        public static readonly Column<SqlInt> IsImpersonating = new Column<SqlInt>("is_impersonating");
        
        public static readonly Column<SqlInt> IsWaitingOnLoaderLock = new Column<SqlInt>("is_waiting_on_loader_lock");
        
        public static readonly Column<SqlBigInt> KernelTime = new Column<SqlBigInt>("kernel_time");
        
        public static readonly Column<SqlInt> Locale = new Column<SqlInt>("locale");
        
        public static readonly Column<SqlInt> OsThreadId = new Column<SqlInt>("os_thread_id");
        
        public static readonly Column<SqlInt> Priority = new Column<SqlInt>("priority");
        
        public static readonly Column<SqlSmallInt> ProcessorGroup = new Column<SqlSmallInt>("processor_group");
        
        public static readonly Column<SqlVarbinary> SchedulerAddress = new Column<SqlVarbinary>("scheduler_address");
        
        public static readonly Column<SqlVarbinary> SelfAddress = new Column<SqlVarbinary>("self_address");
        
        public static readonly Column<SqlVarbinary> StackBaseAddress = new Column<SqlVarbinary>("stack_base_address");
        
        public static readonly Column<SqlInt> StackBytesCommitted = new Column<SqlInt>("stack_bytes_committed");
        
        public static readonly Column<SqlInt> StackBytesUsed = new Column<SqlInt>("stack_bytes_used");
        
        public static readonly Column<SqlVarbinary> StackEndAddress = new Column<SqlVarbinary>("stack_end_address");
        
        public static readonly Column<SqlBit> StartedBySqlservr = new Column<SqlBit>("started_by_sqlservr");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlVarbinary> ThreadAddress = new Column<SqlVarbinary>("thread_address");
        
        public static readonly Column<SqlVarbinary> ThreadHandle = new Column<SqlVarbinary>("thread_handle");
        
        public static readonly Column<SqlVarbinary> Token = new Column<SqlVarbinary>("token");
        
        public static readonly Column<SqlBigInt> UsermodeTime = new Column<SqlBigInt>("usermode_time");
        
        public static readonly Column<SqlVarbinary> WorkerAddress = new Column<SqlVarbinary>("worker_address");
    }
}
