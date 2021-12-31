using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecQueryMemoryGrants
    {
        public static readonly ViewName ViewName = new("sys.dm_exec_query_memory_grants");

        public static readonly Column<SqlSmallInt> Dop = new("dop");

        public static readonly Column<SqlDateTime> GrantTime = new("grant_time");

        public static readonly Column<SqlBigInt> GrantedMemoryKb = new("granted_memory_kb");

        public static readonly Column<SqlInt> GroupId = new("group_id");

        public static readonly Column<SqlBigInt> IdealMemoryKb = new("ideal_memory_kb");

        public static readonly Column<SqlBit> IsNextCandidate = new("is_next_candidate");

        public static readonly Column<SqlBit> IsSmall = new("is_small");

        public static readonly Column<SqlBigInt> MaxUsedMemoryKb = new("max_used_memory_kb");

        public static readonly Column<SqlVarbinary> PlanHandle = new("plan_handle");

        public static readonly Column<SqlInt> PoolId = new("pool_id");

        public static readonly Column<SqlFloat> QueryCost = new("query_cost");

        public static readonly Column<SqlSmallInt> QueueId = new("queue_id");

        public static readonly Column<SqlInt> RequestId = new("request_id");

        public static readonly Column<SqlDateTime> RequestTime = new("request_time");

        public static readonly Column<SqlBigInt> RequestedMemoryKb = new("requested_memory_kb");

        public static readonly Column<SqlBigInt> RequiredMemoryKb = new("required_memory_kb");

        public static readonly Column<SqlSmallInt> ResourceSemaphoreId = new("resource_semaphore_id");

        public static readonly Column<SqlInt> SchedulerId = new("scheduler_id");

        public static readonly Column<SqlSmallInt> SessionId = new("session_id");

        public static readonly Column<SqlVarbinary> SqlHandle = new("sql_handle");

        public static readonly Column<SqlInt> TimeoutSec = new("timeout_sec");

        public static readonly Column<SqlBigInt> UsedMemoryKb = new("used_memory_kb");

        public static readonly Column<SqlInt> WaitOrder = new("wait_order");

        public static readonly Column<SqlBigInt> WaitTimeMs = new("wait_time_ms");
    }
}
