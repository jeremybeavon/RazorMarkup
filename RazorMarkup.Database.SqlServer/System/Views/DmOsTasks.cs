using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsTasks
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_tasks");
        
        public static readonly Column<SqlInt> ContextSwitchesCount = new Column<SqlInt>("context_switches_count");
        
        public static readonly Column<SqlInt> ExecContextId = new Column<SqlInt>("exec_context_id");
        
        public static readonly Column<SqlVarbinary> HostAddress = new Column<SqlVarbinary>("host_address");
        
        public static readonly Column<SqlVarbinary> ParentTaskAddress = new Column<SqlVarbinary>("parent_task_address");
        
        public static readonly Column<SqlInt> PendingIoByteAverage = new Column<SqlInt>("pending_io_byte_average");
        
        public static readonly Column<SqlBigInt> PendingIoByteCount = new Column<SqlBigInt>("pending_io_byte_count");
        
        public static readonly Column<SqlInt> PendingIoCount = new Column<SqlInt>("pending_io_count");
        
        public static readonly Column<SqlInt> RequestId = new Column<SqlInt>("request_id");
        
        public static readonly Column<SqlInt> SchedulerId = new Column<SqlInt>("scheduler_id");
        
        public static readonly Column<SqlSmallInt> SessionId = new Column<SqlSmallInt>("session_id");
        
        public static readonly Column<SqlVarbinary> TaskAddress = new Column<SqlVarbinary>("task_address");
        
        public static readonly Column<SqlNVarchar> TaskState = new Column<SqlNVarchar>("task_state");
        
        public static readonly Column<SqlVarbinary> WorkerAddress = new Column<SqlVarbinary>("worker_address");
    }
}
