using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecQueryMemoryGrants
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_exec_query_memory_grants");
        
        public static readonly Column<SqlSmallInt> Dop = new Column<SqlSmallInt>("dop");
        
        public static readonly Column<SqlDateTime> GrantTime = new Column<SqlDateTime>("grant_time");
        
        public static readonly Column<SqlBigInt> GrantedMemoryKb = new Column<SqlBigInt>("granted_memory_kb");
        
        public static readonly Column<SqlInt> GroupId = new Column<SqlInt>("group_id");
        
        public static readonly Column<SqlBigInt> IdealMemoryKb = new Column<SqlBigInt>("ideal_memory_kb");
        
        public static readonly Column<SqlBit> IsNextCandidate = new Column<SqlBit>("is_next_candidate");
        
        public static readonly Column<SqlBit> IsSmall = new Column<SqlBit>("is_small");
        
        public static readonly Column<SqlBigInt> MaxUsedMemoryKb = new Column<SqlBigInt>("max_used_memory_kb");
        
        public static readonly Column<SqlVarbinary> PlanHandle = new Column<SqlVarbinary>("plan_handle");
        
        public static readonly Column<SqlInt> PoolId = new Column<SqlInt>("pool_id");
        
        public static readonly Column<SqlFloat> QueryCost = new Column<SqlFloat>("query_cost");
        
        public static readonly Column<SqlSmallInt> QueueId = new Column<SqlSmallInt>("queue_id");
        
        public static readonly Column<SqlInt> RequestId = new Column<SqlInt>("request_id");
        
        public static readonly Column<SqlDateTime> RequestTime = new Column<SqlDateTime>("request_time");
        
        public static readonly Column<SqlBigInt> RequestedMemoryKb = new Column<SqlBigInt>("requested_memory_kb");
        
        public static readonly Column<SqlBigInt> RequiredMemoryKb = new Column<SqlBigInt>("required_memory_kb");
        
        public static readonly Column<SqlSmallInt> ResourceSemaphoreId = new Column<SqlSmallInt>("resource_semaphore_id");
        
        public static readonly Column<SqlInt> SchedulerId = new Column<SqlInt>("scheduler_id");
        
        public static readonly Column<SqlSmallInt> SessionId = new Column<SqlSmallInt>("session_id");
        
        public static readonly Column<SqlVarbinary> SqlHandle = new Column<SqlVarbinary>("sql_handle");
        
        public static readonly Column<SqlInt> TimeoutSec = new Column<SqlInt>("timeout_sec");
        
        public static readonly Column<SqlBigInt> UsedMemoryKb = new Column<SqlBigInt>("used_memory_kb");
        
        public static readonly Column<SqlInt> WaitOrder = new Column<SqlInt>("wait_order");
        
        public static readonly Column<SqlBigInt> WaitTimeMs = new Column<SqlBigInt>("wait_time_ms");
    }
}
