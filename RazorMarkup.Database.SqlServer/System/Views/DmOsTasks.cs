using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsTasks
    {
        public static readonly ViewName ViewName = new("sys.dm_os_tasks");

        public static readonly Column<SqlInt> ContextSwitchesCount = new("context_switches_count");

        public static readonly Column<SqlInt> ExecContextId = new("exec_context_id");

        public static readonly Column<SqlVarbinary> HostAddress = new("host_address");

        public static readonly Column<SqlVarbinary> ParentTaskAddress = new("parent_task_address");

        public static readonly Column<SqlInt> PendingIoByteAverage = new("pending_io_byte_average");

        public static readonly Column<SqlBigInt> PendingIoByteCount = new("pending_io_byte_count");

        public static readonly Column<SqlInt> PendingIoCount = new("pending_io_count");

        public static readonly Column<SqlInt> RequestId = new("request_id");

        public static readonly Column<SqlInt> SchedulerId = new("scheduler_id");

        public static readonly Column<SqlSmallInt> SessionId = new("session_id");

        public static readonly Column<SqlVarbinary> TaskAddress = new("task_address");

        public static readonly Column<SqlNVarchar> TaskState = new("task_state");

        public static readonly Column<SqlVarbinary> WorkerAddress = new("worker_address");
    }
}
