using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsDispatcherPools
    {
        public static readonly ViewName ViewName = new("sys.dm_os_dispatcher_pools");

        public static readonly Column<SqlInt> DispatcherCount = new("dispatcher_count");

        public static readonly Column<SqlInt> DispatcherIdealCount = new("dispatcher_ideal_count");

        public static readonly Column<SqlVarbinary> DispatcherPoolAddress = new("dispatcher_pool_address");

        public static readonly Column<SqlInt> DispatcherTimeoutMs = new("dispatcher_timeout_ms");

        public static readonly Column<SqlInt> DispatcherWaitingCount = new("dispatcher_waiting_count");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlInt> QueueLength = new("queue_length");

        public static readonly Column<SqlNVarchar> Type = new("type");
    }
}
