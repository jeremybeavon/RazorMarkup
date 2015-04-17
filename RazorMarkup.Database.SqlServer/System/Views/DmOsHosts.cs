using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsHosts
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_hosts");
        
        public static readonly Column<SqlInt> ActiveIosCount = new Column<SqlInt>("active_ios_count");
        
        public static readonly Column<SqlInt> ActiveTasksCount = new Column<SqlInt>("active_tasks_count");
        
        public static readonly Column<SqlInt> CompletedIosCount = new Column<SqlInt>("completed_ios_count");
        
        public static readonly Column<SqlBigInt> CompletedIosInBytes = new Column<SqlBigInt>("completed_ios_in_bytes");
        
        public static readonly Column<SqlVarbinary> DefaultMemoryClerkAddress = new Column<SqlVarbinary>("default_memory_clerk_address");
        
        public static readonly Column<SqlInt> EnqueuedTasksCount = new Column<SqlInt>("enqueued_tasks_count");
        
        public static readonly Column<SqlVarbinary> HostAddress = new Column<SqlVarbinary>("host_address");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlNVarchar> Type = new Column<SqlNVarchar>("type");
    }
}
