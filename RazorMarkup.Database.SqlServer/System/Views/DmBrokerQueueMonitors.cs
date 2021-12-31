using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmBrokerQueueMonitors
    {
        public static readonly ViewName ViewName = new("sys.dm_broker_queue_monitors");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlDateTime> LastActivatedTime = new("last_activated_time");

        public static readonly Column<SqlDateTime> LastEmptyRowsetTime = new("last_empty_rowset_time");

        public static readonly Column<SqlInt> QueueId = new("queue_id");

        public static readonly Column<SqlNVarchar> State = new("state");

        public static readonly Column<SqlInt> TasksWaiting = new("tasks_waiting");
    }
}
