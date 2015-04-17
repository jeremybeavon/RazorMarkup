using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmResourceGovernorWorkloadGroups
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_resource_governor_workload_groups");
        
        public static readonly Column<SqlBigInt> ActiveParallelThreadCount = new Column<SqlBigInt>("active_parallel_thread_count");
        
        public static readonly Column<SqlInt> ActiveRequestCount = new Column<SqlInt>("active_request_count");
        
        public static readonly Column<SqlInt> BlockedTaskCount = new Column<SqlInt>("blocked_task_count");
        
        public static readonly Column<SqlInt> EffectiveMaxDop = new Column<SqlInt>("effective_max_dop");
        
        public static readonly Column<SqlInt> GroupId = new Column<SqlInt>("group_id");
        
        public static readonly Column<SqlInt> GroupMaxRequests = new Column<SqlInt>("group_max_requests");
        
        public static readonly Column<SqlNVarchar> Importance = new Column<SqlNVarchar>("importance");
        
        public static readonly Column<SqlInt> MaxDop = new Column<SqlInt>("max_dop");
        
        public static readonly Column<SqlBigInt> MaxRequestCpuTimeMs = new Column<SqlBigInt>("max_request_cpu_time_ms");
        
        public static readonly Column<SqlBigInt> MaxRequestGrantMemoryKb = new Column<SqlBigInt>("max_request_grant_memory_kb");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlInt> PoolId = new Column<SqlInt>("pool_id");
        
        public static readonly Column<SqlInt> QueuedRequestCount = new Column<SqlInt>("queued_request_count");
        
        public static readonly Column<SqlInt> RequestMaxCpuTimeSec = new Column<SqlInt>("request_max_cpu_time_sec");
        
        public static readonly Column<SqlInt> RequestMaxMemoryGrantPercent = new Column<SqlInt>("request_max_memory_grant_percent");
        
        public static readonly Column<SqlInt> RequestMemoryGrantTimeoutSec = new Column<SqlInt>("request_memory_grant_timeout_sec");
        
        public static readonly Column<SqlDateTime> StatisticsStartTime = new Column<SqlDateTime>("statistics_start_time");
        
        public static readonly Column<SqlBigInt> TotalCpuLimitViolationCount = new Column<SqlBigInt>("total_cpu_limit_violation_count");
        
        public static readonly Column<SqlBigInt> TotalCpuUsageMs = new Column<SqlBigInt>("total_cpu_usage_ms");
        
        public static readonly Column<SqlBigInt> TotalLockWaitCount = new Column<SqlBigInt>("total_lock_wait_count");
        
        public static readonly Column<SqlBigInt> TotalLockWaitTimeMs = new Column<SqlBigInt>("total_lock_wait_time_ms");
        
        public static readonly Column<SqlBigInt> TotalQueryOptimizationCount = new Column<SqlBigInt>("total_query_optimization_count");
        
        public static readonly Column<SqlBigInt> TotalQueuedRequestCount = new Column<SqlBigInt>("total_queued_request_count");
        
        public static readonly Column<SqlBigInt> TotalReducedMemgrantCount = new Column<SqlBigInt>("total_reduced_memgrant_count");
        
        public static readonly Column<SqlBigInt> TotalRequestCount = new Column<SqlBigInt>("total_request_count");
        
        public static readonly Column<SqlBigInt> TotalSuboptimalPlanGenerationCount = new Column<SqlBigInt>("total_suboptimal_plan_generation_count");
    }
}
