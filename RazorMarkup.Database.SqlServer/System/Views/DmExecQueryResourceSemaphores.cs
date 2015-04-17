using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecQueryResourceSemaphores
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_exec_query_resource_semaphores");
        
        public static readonly Column<SqlBigInt> AvailableMemoryKb = new Column<SqlBigInt>("available_memory_kb");
        
        public static readonly Column<SqlBigInt> ForcedGrantCount = new Column<SqlBigInt>("forced_grant_count");
        
        public static readonly Column<SqlBigInt> GrantedMemoryKb = new Column<SqlBigInt>("granted_memory_kb");
        
        public static readonly Column<SqlInt> GranteeCount = new Column<SqlInt>("grantee_count");
        
        public static readonly Column<SqlBigInt> MaxTargetMemoryKb = new Column<SqlBigInt>("max_target_memory_kb");
        
        public static readonly Column<SqlInt> PoolId = new Column<SqlInt>("pool_id");
        
        public static readonly Column<SqlSmallInt> ResourceSemaphoreId = new Column<SqlSmallInt>("resource_semaphore_id");
        
        public static readonly Column<SqlBigInt> TargetMemoryKb = new Column<SqlBigInt>("target_memory_kb");
        
        public static readonly Column<SqlBigInt> TimeoutErrorCount = new Column<SqlBigInt>("timeout_error_count");
        
        public static readonly Column<SqlBigInt> TotalMemoryKb = new Column<SqlBigInt>("total_memory_kb");
        
        public static readonly Column<SqlBigInt> UsedMemoryKb = new Column<SqlBigInt>("used_memory_kb");
        
        public static readonly Column<SqlInt> WaiterCount = new Column<SqlInt>("waiter_count");
    }
}
