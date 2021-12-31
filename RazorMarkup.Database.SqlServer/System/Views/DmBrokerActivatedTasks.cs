using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmBrokerActivatedTasks
    {
        public static readonly ViewName ViewName = new("sys.dm_broker_activated_tasks");

        public static readonly Column<SqlSmallInt> DatabaseId = new("database_id");

        public static readonly Column<SqlInt> ExecuteAs = new("execute_as");

        public static readonly Column<SqlNVarchar> ProcedureName = new("procedure_name");

        public static readonly Column<SqlInt> QueueId = new("queue_id");

        public static readonly Column<SqlInt> Spid = new("spid");
    }
}
