using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsWaitingTasks
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_waiting_tasks");
        
        public static readonly Column<SqlInt> BlockingExecContextId = new Column<SqlInt>("blocking_exec_context_id");
        
        public static readonly Column<SqlSmallInt> BlockingSessionId = new Column<SqlSmallInt>("blocking_session_id");
        
        public static readonly Column<SqlVarbinary> BlockingTaskAddress = new Column<SqlVarbinary>("blocking_task_address");
        
        public static readonly Column<SqlInt> ExecContextId = new Column<SqlInt>("exec_context_id");
        
        public static readonly Column<SqlVarbinary> ResourceAddress = new Column<SqlVarbinary>("resource_address");
        
        public static readonly Column<SqlNVarchar> ResourceDescription = new Column<SqlNVarchar>("resource_description");
        
        public static readonly Column<SqlSmallInt> SessionId = new Column<SqlSmallInt>("session_id");
        
        public static readonly Column<SqlBigInt> WaitDurationMs = new Column<SqlBigInt>("wait_duration_ms");
        
        public static readonly Column<SqlNVarchar> WaitType = new Column<SqlNVarchar>("wait_type");
        
        public static readonly Column<SqlVarbinary> WaitingTaskAddress = new Column<SqlVarbinary>("waiting_task_address");
    }
}
