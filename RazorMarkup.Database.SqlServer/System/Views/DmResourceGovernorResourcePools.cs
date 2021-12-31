using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmResourceGovernorResourcePools
    {
        public static readonly ViewName ViewName = new("sys.dm_resource_governor_resource_pools");

        public static readonly Column<SqlInt> ActiveMemgrantCount = new("active_memgrant_count");

        public static readonly Column<SqlBigInt> ActiveMemgrantKb = new("active_memgrant_kb");

        public static readonly Column<SqlBigInt> CacheMemoryKb = new("cache_memory_kb");

        public static readonly Column<SqlInt> CapCpuPercent = new("cap_cpu_percent");

        public static readonly Column<SqlBigInt> CompileMemoryKb = new("compile_memory_kb");

        public static readonly Column<SqlInt> MaxCpuPercent = new("max_cpu_percent");

        public static readonly Column<SqlBigInt> MaxMemoryKb = new("max_memory_kb");

        public static readonly Column<SqlInt> MaxMemoryPercent = new("max_memory_percent");

        public static readonly Column<SqlInt> MemgrantWaiterCount = new("memgrant_waiter_count");

        public static readonly Column<SqlInt> MinCpuPercent = new("min_cpu_percent");

        public static readonly Column<SqlInt> MinMemoryPercent = new("min_memory_percent");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlBigInt> OutOfMemoryCount = new("out_of_memory_count");

        public static readonly Column<SqlInt> PoolId = new("pool_id");

        public static readonly Column<SqlDateTime> StatisticsStartTime = new("statistics_start_time");

        public static readonly Column<SqlBigInt> TargetMemoryKb = new("target_memory_kb");

        public static readonly Column<SqlBigInt> TotalCpuUsageMs = new("total_cpu_usage_ms");

        public static readonly Column<SqlBigInt> TotalMemgrantCount = new("total_memgrant_count");

        public static readonly Column<SqlBigInt> TotalMemgrantTimeoutCount = new("total_memgrant_timeout_count");

        public static readonly Column<SqlBigInt> UsedMemgrantKb = new("used_memgrant_kb");

        public static readonly Column<SqlBigInt> UsedMemoryKb = new("used_memory_kb");
    }
}
