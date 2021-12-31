using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsHosts
    {
        public static readonly ViewName ViewName = new("sys.dm_os_hosts");

        public static readonly Column<SqlInt> ActiveIosCount = new("active_ios_count");

        public static readonly Column<SqlInt> ActiveTasksCount = new("active_tasks_count");

        public static readonly Column<SqlInt> CompletedIosCount = new("completed_ios_count");

        public static readonly Column<SqlBigInt> CompletedIosInBytes = new("completed_ios_in_bytes");

        public static readonly Column<SqlVarbinary> DefaultMemoryClerkAddress = new("default_memory_clerk_address");

        public static readonly Column<SqlInt> EnqueuedTasksCount = new("enqueued_tasks_count");

        public static readonly Column<SqlVarbinary> HostAddress = new("host_address");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlNVarchar> Type = new("type");
    }
}
