using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsWaitStats
    {
        public static readonly ViewName ViewName = new("sys.dm_os_wait_stats");

        public static readonly Column<SqlBigInt> MaxWaitTimeMs = new("max_wait_time_ms");

        public static readonly Column<SqlBigInt> SignalWaitTimeMs = new("signal_wait_time_ms");

        public static readonly Column<SqlBigInt> WaitTimeMs = new("wait_time_ms");

        public static readonly Column<SqlNVarchar> WaitType = new("wait_type");

        public static readonly Column<SqlBigInt> WaitingTasksCount = new("waiting_tasks_count");
    }
}
