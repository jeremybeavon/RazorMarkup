using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmResourceGovernorResourcePools
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_resource_governor_resource_pools");
        
        public static readonly Column<SqlInt> ActiveMemgrantCount = new Column<SqlInt>("active_memgrant_count");
        
        public static readonly Column<SqlBigInt> ActiveMemgrantKb = new Column<SqlBigInt>("active_memgrant_kb");
        
        public static readonly Column<SqlBigInt> CacheMemoryKb = new Column<SqlBigInt>("cache_memory_kb");
        
        public static readonly Column<SqlInt> CapCpuPercent = new Column<SqlInt>("cap_cpu_percent");
        
        public static readonly Column<SqlBigInt> CompileMemoryKb = new Column<SqlBigInt>("compile_memory_kb");
        
        public static readonly Column<SqlInt> MaxCpuPercent = new Column<SqlInt>("max_cpu_percent");
        
        public static readonly Column<SqlBigInt> MaxMemoryKb = new Column<SqlBigInt>("max_memory_kb");
        
        public static readonly Column<SqlInt> MaxMemoryPercent = new Column<SqlInt>("max_memory_percent");
        
        public static readonly Column<SqlInt> MemgrantWaiterCount = new Column<SqlInt>("memgrant_waiter_count");
        
        public static readonly Column<SqlInt> MinCpuPercent = new Column<SqlInt>("min_cpu_percent");
        
        public static readonly Column<SqlInt> MinMemoryPercent = new Column<SqlInt>("min_memory_percent");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlBigInt> OutOfMemoryCount = new Column<SqlBigInt>("out_of_memory_count");
        
        public static readonly Column<SqlInt> PoolId = new Column<SqlInt>("pool_id");
        
        public static readonly Column<SqlDateTime> StatisticsStartTime = new Column<SqlDateTime>("statistics_start_time");
        
        public static readonly Column<SqlBigInt> TargetMemoryKb = new Column<SqlBigInt>("target_memory_kb");
        
        public static readonly Column<SqlBigInt> TotalCpuUsageMs = new Column<SqlBigInt>("total_cpu_usage_ms");
        
        public static readonly Column<SqlBigInt> TotalMemgrantCount = new Column<SqlBigInt>("total_memgrant_count");
        
        public static readonly Column<SqlBigInt> TotalMemgrantTimeoutCount = new Column<SqlBigInt>("total_memgrant_timeout_count");
        
        public static readonly Column<SqlBigInt> UsedMemgrantKb = new Column<SqlBigInt>("used_memgrant_kb");
        
        public static readonly Column<SqlBigInt> UsedMemoryKb = new Column<SqlBigInt>("used_memory_kb");
    }
}
