using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmResourceGovernorWorkloadGroups
    {
        public static readonly ViewName ViewName = new("sys.dm_resource_governor_workload_groups");

        public static readonly Column<SqlBigInt> ActiveParallelThreadCount = new("active_parallel_thread_count");

        public static readonly Column<SqlInt> ActiveRequestCount = new("active_request_count");

        public static readonly Column<SqlInt> BlockedTaskCount = new("blocked_task_count");

        public static readonly Column<SqlInt> EffectiveMaxDop = new("effective_max_dop");

        public static readonly Column<SqlInt> GroupId = new("group_id");

        public static readonly Column<SqlInt> GroupMaxRequests = new("group_max_requests");

        public static readonly Column<SqlNVarchar> Importance = new("importance");

        public static readonly Column<SqlInt> MaxDop = new("max_dop");

        public static readonly Column<SqlBigInt> MaxRequestCpuTimeMs = new("max_request_cpu_time_ms");

        public static readonly Column<SqlBigInt> MaxRequestGrantMemoryKb = new("max_request_grant_memory_kb");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlInt> PoolId = new("pool_id");

        public static readonly Column<SqlInt> QueuedRequestCount = new("queued_request_count");

        public static readonly Column<SqlInt> RequestMaxCpuTimeSec = new("request_max_cpu_time_sec");

        public static readonly Column<SqlInt> RequestMaxMemoryGrantPercent = new("request_max_memory_grant_percent");

        public static readonly Column<SqlInt> RequestMemoryGrantTimeoutSec = new("request_memory_grant_timeout_sec");

        public static readonly Column<SqlDateTime> StatisticsStartTime = new("statistics_start_time");

        public static readonly Column<SqlBigInt> TotalCpuLimitViolationCount = new("total_cpu_limit_violation_count");

        public static readonly Column<SqlBigInt> TotalCpuUsageMs = new("total_cpu_usage_ms");

        public static readonly Column<SqlBigInt> TotalLockWaitCount = new("total_lock_wait_count");

        public static readonly Column<SqlBigInt> TotalLockWaitTimeMs = new("total_lock_wait_time_ms");

        public static readonly Column<SqlBigInt> TotalQueryOptimizationCount = new("total_query_optimization_count");

        public static readonly Column<SqlBigInt> TotalQueuedRequestCount = new("total_queued_request_count");

        public static readonly Column<SqlBigInt> TotalReducedMemgrantCount = new("total_reduced_memgrant_count");

        public static readonly Column<SqlBigInt> TotalRequestCount = new("total_request_count");

        public static readonly Column<SqlBigInt> TotalSuboptimalPlanGenerationCount = new("total_suboptimal_plan_generation_count");
    }
}
