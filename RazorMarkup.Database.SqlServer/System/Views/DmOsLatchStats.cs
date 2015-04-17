using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsLatchStats
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_latch_stats");
        
        public static readonly Column<SqlNVarchar> LatchClass = new Column<SqlNVarchar>("latch_class");
        
        public static readonly Column<SqlBigInt> MaxWaitTimeMs = new Column<SqlBigInt>("max_wait_time_ms");
        
        public static readonly Column<SqlBigInt> WaitTimeMs = new Column<SqlBigInt>("wait_time_ms");
        
        public static readonly Column<SqlBigInt> WaitingRequestsCount = new Column<SqlBigInt>("waiting_requests_count");
    }
}
