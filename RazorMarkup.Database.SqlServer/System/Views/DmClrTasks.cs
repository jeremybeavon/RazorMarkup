using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmClrTasks
    {
        public static readonly ViewName ViewName = new("sys.dm_clr_tasks");

        public static readonly Column<SqlNVarchar> AbortState = new("abort_state");

        public static readonly Column<SqlInt> AffinityCount = new("affinity_count");

        public static readonly Column<SqlVarbinary> AppdomainAddress = new("appdomain_address");

        public static readonly Column<SqlInt> ForcedYieldCount = new("forced_yield_count");

        public static readonly Column<SqlVarbinary> SosTaskAddress = new("sos_task_address");

        public static readonly Column<SqlNVarchar> State = new("state");

        public static readonly Column<SqlVarbinary> TaskAddress = new("task_address");

        public static readonly Column<SqlNVarchar> Type = new("type");
    }
}
