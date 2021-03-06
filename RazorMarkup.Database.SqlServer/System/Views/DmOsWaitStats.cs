using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsWaitStats
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_wait_stats");
        
        public static readonly Column<SqlBigInt> MaxWaitTimeMs = new Column<SqlBigInt>("max_wait_time_ms");
        
        public static readonly Column<SqlBigInt> SignalWaitTimeMs = new Column<SqlBigInt>("signal_wait_time_ms");
        
        public static readonly Column<SqlBigInt> WaitTimeMs = new Column<SqlBigInt>("wait_time_ms");
        
        public static readonly Column<SqlNVarchar> WaitType = new Column<SqlNVarchar>("wait_type");
        
        public static readonly Column<SqlBigInt> WaitingTasksCount = new Column<SqlBigInt>("waiting_tasks_count");
    }
}
