using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ResourceGovernorResourcePools
    {
        public static readonly ViewName ViewName = new ViewName("sys.resource_governor_resource_pools");
        
        public static readonly Column<SqlInt> CapCpuPercent = new Column<SqlInt>("cap_cpu_percent");
        
        public static readonly Column<SqlInt> MaxCpuPercent = new Column<SqlInt>("max_cpu_percent");
        
        public static readonly Column<SqlInt> MaxMemoryPercent = new Column<SqlInt>("max_memory_percent");
        
        public static readonly Column<SqlInt> MinCpuPercent = new Column<SqlInt>("min_cpu_percent");
        
        public static readonly Column<SqlInt> MinMemoryPercent = new Column<SqlInt>("min_memory_percent");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> PoolId = new Column<SqlInt>("pool_id");
    }
}
