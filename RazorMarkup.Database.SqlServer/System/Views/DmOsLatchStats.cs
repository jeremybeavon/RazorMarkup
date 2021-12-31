using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsLatchStats
    {
        public static readonly ViewName ViewName = new("sys.dm_os_latch_stats");

        public static readonly Column<SqlNVarchar> LatchClass = new("latch_class");

        public static readonly Column<SqlBigInt> MaxWaitTimeMs = new("max_wait_time_ms");

        public static readonly Column<SqlBigInt> WaitTimeMs = new("wait_time_ms");

        public static readonly Column<SqlBigInt> WaitingRequestsCount = new("waiting_requests_count");
    }
}
