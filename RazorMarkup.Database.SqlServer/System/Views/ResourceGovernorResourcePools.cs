using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ResourceGovernorResourcePools
    {
        public static readonly ViewName ViewName = new("sys.resource_governor_resource_pools");

        public static readonly Column<SqlInt> CapCpuPercent = new("cap_cpu_percent");

        public static readonly Column<SqlInt> MaxCpuPercent = new("max_cpu_percent");

        public static readonly Column<SqlInt> MaxMemoryPercent = new("max_memory_percent");

        public static readonly Column<SqlInt> MinCpuPercent = new("min_cpu_percent");

        public static readonly Column<SqlInt> MinMemoryPercent = new("min_memory_percent");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PoolId = new("pool_id");
    }
}
