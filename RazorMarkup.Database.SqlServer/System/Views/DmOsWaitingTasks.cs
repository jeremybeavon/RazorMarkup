using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsWaitingTasks
    {
        public static readonly ViewName ViewName = new("sys.dm_os_waiting_tasks");

        public static readonly Column<SqlInt> BlockingExecContextId = new("blocking_exec_context_id");

        public static readonly Column<SqlSmallInt> BlockingSessionId = new("blocking_session_id");

        public static readonly Column<SqlVarbinary> BlockingTaskAddress = new("blocking_task_address");

        public static readonly Column<SqlInt> ExecContextId = new("exec_context_id");

        public static readonly Column<SqlVarbinary> ResourceAddress = new("resource_address");

        public static readonly Column<SqlNVarchar> ResourceDescription = new("resource_description");

        public static readonly Column<SqlSmallInt> SessionId = new("session_id");

        public static readonly Column<SqlBigInt> WaitDurationMs = new("wait_duration_ms");

        public static readonly Column<SqlNVarchar> WaitType = new("wait_type");

        public static readonly Column<SqlVarbinary> WaitingTaskAddress = new("waiting_task_address");
    }
}
