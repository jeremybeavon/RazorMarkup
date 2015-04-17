using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmClrTasks
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_clr_tasks");
        
        public static readonly Column<SqlNVarchar> AbortState = new Column<SqlNVarchar>("abort_state");
        
        public static readonly Column<SqlInt> AffinityCount = new Column<SqlInt>("affinity_count");
        
        public static readonly Column<SqlVarbinary> AppdomainAddress = new Column<SqlVarbinary>("appdomain_address");
        
        public static readonly Column<SqlInt> ForcedYieldCount = new Column<SqlInt>("forced_yield_count");
        
        public static readonly Column<SqlVarbinary> SosTaskAddress = new Column<SqlVarbinary>("sos_task_address");
        
        public static readonly Column<SqlNVarchar> State = new Column<SqlNVarchar>("state");
        
        public static readonly Column<SqlVarbinary> TaskAddress = new Column<SqlVarbinary>("task_address");
        
        public static readonly Column<SqlNVarchar> Type = new Column<SqlNVarchar>("type");
    }
}
