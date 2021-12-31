using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsMemoryBrokers
    {
        public static readonly ViewName ViewName = new("sys.dm_os_memory_brokers");

        public static readonly Column<SqlBigInt> AllocationsKb = new("allocations_kb");

        public static readonly Column<SqlBigInt> AllocationsKbPerSec = new("allocations_kb_per_sec");

        public static readonly Column<SqlBigInt> FutureAllocationsKb = new("future_allocations_kb");

        public static readonly Column<SqlNVarchar> LastNotification = new("last_notification");

        public static readonly Column<SqlNVarchar> MemoryBrokerType = new("memory_broker_type");

        public static readonly Column<SqlBigInt> OverallLimitKb = new("overall_limit_kb");

        public static readonly Column<SqlInt> PoolId = new("pool_id");

        public static readonly Column<SqlBigInt> PredictedAllocationsKb = new("predicted_allocations_kb");

        public static readonly Column<SqlBigInt> TargetAllocationsKb = new("target_allocations_kb");
    }
}
