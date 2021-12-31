using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecQueryResourceSemaphores
    {
        public static readonly ViewName ViewName = new("sys.dm_exec_query_resource_semaphores");

        public static readonly Column<SqlBigInt> AvailableMemoryKb = new("available_memory_kb");

        public static readonly Column<SqlBigInt> ForcedGrantCount = new("forced_grant_count");

        public static readonly Column<SqlBigInt> GrantedMemoryKb = new("granted_memory_kb");

        public static readonly Column<SqlInt> GranteeCount = new("grantee_count");

        public static readonly Column<SqlBigInt> MaxTargetMemoryKb = new("max_target_memory_kb");

        public static readonly Column<SqlInt> PoolId = new("pool_id");

        public static readonly Column<SqlSmallInt> ResourceSemaphoreId = new("resource_semaphore_id");

        public static readonly Column<SqlBigInt> TargetMemoryKb = new("target_memory_kb");

        public static readonly Column<SqlBigInt> TimeoutErrorCount = new("timeout_error_count");

        public static readonly Column<SqlBigInt> TotalMemoryKb = new("total_memory_kb");

        public static readonly Column<SqlBigInt> UsedMemoryKb = new("used_memory_kb");

        public static readonly Column<SqlInt> WaiterCount = new("waiter_count");
    }
}
