using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ResourceGovernorWorkloadGroups
    {
        public static readonly ViewName ViewName = new("sys.resource_governor_workload_groups");

        public static readonly Column<SqlInt> GroupId = new("group_id");

        public static readonly Column<SqlInt> GroupMaxRequests = new("group_max_requests");

        public static readonly Column<SqlSysname> Importance = new("importance");

        public static readonly Column<SqlInt> MaxDop = new("max_dop");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PoolId = new("pool_id");

        public static readonly Column<SqlInt> RequestMaxCpuTimeSec = new("request_max_cpu_time_sec");

        public static readonly Column<SqlInt> RequestMaxMemoryGrantPercent = new("request_max_memory_grant_percent");

        public static readonly Column<SqlInt> RequestMemoryGrantTimeoutSec = new("request_memory_grant_timeout_sec");
    }
}
