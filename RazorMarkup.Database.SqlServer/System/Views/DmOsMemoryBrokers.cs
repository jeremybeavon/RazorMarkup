using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryBrokers
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_memory_brokers");
        
        public static readonly Column<SqlBigInt> AllocationsKb = new Column<SqlBigInt>("allocations_kb");
        
        public static readonly Column<SqlBigInt> AllocationsKbPerSec = new Column<SqlBigInt>("allocations_kb_per_sec");
        
        public static readonly Column<SqlBigInt> FutureAllocationsKb = new Column<SqlBigInt>("future_allocations_kb");
        
        public static readonly Column<SqlNVarchar> LastNotification = new Column<SqlNVarchar>("last_notification");
        
        public static readonly Column<SqlNVarchar> MemoryBrokerType = new Column<SqlNVarchar>("memory_broker_type");
        
        public static readonly Column<SqlBigInt> OverallLimitKb = new Column<SqlBigInt>("overall_limit_kb");
        
        public static readonly Column<SqlInt> PoolId = new Column<SqlInt>("pool_id");
        
        public static readonly Column<SqlBigInt> PredictedAllocationsKb = new Column<SqlBigInt>("predicted_allocations_kb");
        
        public static readonly Column<SqlBigInt> TargetAllocationsKb = new Column<SqlBigInt>("target_allocations_kb");
    }
}
