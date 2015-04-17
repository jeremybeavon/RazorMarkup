using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmBrokerActivatedTasks
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_broker_activated_tasks");
        
        public static readonly Column<SqlSmallInt> DatabaseId = new Column<SqlSmallInt>("database_id");
        
        public static readonly Column<SqlInt> ExecuteAs = new Column<SqlInt>("execute_as");
        
        public static readonly Column<SqlNVarchar> ProcedureName = new Column<SqlNVarchar>("procedure_name");
        
        public static readonly Column<SqlInt> QueueId = new Column<SqlInt>("queue_id");
        
        public static readonly Column<SqlInt> Spid = new Column<SqlInt>("spid");
    }
}
