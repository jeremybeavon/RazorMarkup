using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsDispatcherPools
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_dispatcher_pools");
        
        public static readonly Column<SqlInt> DispatcherCount = new Column<SqlInt>("dispatcher_count");
        
        public static readonly Column<SqlInt> DispatcherIdealCount = new Column<SqlInt>("dispatcher_ideal_count");
        
        public static readonly Column<SqlVarbinary> DispatcherPoolAddress = new Column<SqlVarbinary>("dispatcher_pool_address");
        
        public static readonly Column<SqlInt> DispatcherTimeoutMs = new Column<SqlInt>("dispatcher_timeout_ms");
        
        public static readonly Column<SqlInt> DispatcherWaitingCount = new Column<SqlInt>("dispatcher_waiting_count");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlInt> QueueLength = new Column<SqlInt>("queue_length");
        
        public static readonly Column<SqlNVarchar> Type = new Column<SqlNVarchar>("type");
    }
}
