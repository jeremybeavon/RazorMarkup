using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmBrokerQueueMonitors
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_broker_queue_monitors");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlDateTime> LastActivatedTime = new Column<SqlDateTime>("last_activated_time");
        
        public static readonly Column<SqlDateTime> LastEmptyRowsetTime = new Column<SqlDateTime>("last_empty_rowset_time");
        
        public static readonly Column<SqlInt> QueueId = new Column<SqlInt>("queue_id");
        
        public static readonly Column<SqlNVarchar> State = new Column<SqlNVarchar>("state");
        
        public static readonly Column<SqlInt> TasksWaiting = new Column<SqlInt>("tasks_waiting");
    }
}
