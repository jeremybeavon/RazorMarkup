using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ResourceGovernorWorkloadGroups
    {
        public static readonly ViewName ViewName = new ViewName("sys.resource_governor_workload_groups");
        
        public static readonly Column<SqlInt> GroupId = new Column<SqlInt>("group_id");
        
        public static readonly Column<SqlInt> GroupMaxRequests = new Column<SqlInt>("group_max_requests");
        
        public static readonly Column<SqlSysname> Importance = new Column<SqlSysname>("importance");
        
        public static readonly Column<SqlInt> MaxDop = new Column<SqlInt>("max_dop");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> PoolId = new Column<SqlInt>("pool_id");
        
        public static readonly Column<SqlInt> RequestMaxCpuTimeSec = new Column<SqlInt>("request_max_cpu_time_sec");
        
        public static readonly Column<SqlInt> RequestMaxMemoryGrantPercent = new Column<SqlInt>("request_max_memory_grant_percent");
        
        public static readonly Column<SqlInt> RequestMemoryGrantTimeoutSec = new Column<SqlInt>("request_memory_grant_timeout_sec");
    }
}
