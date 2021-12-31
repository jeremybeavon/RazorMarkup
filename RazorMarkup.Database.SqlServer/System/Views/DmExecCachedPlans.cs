using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecCachedPlans
    {
        public static readonly ViewName ViewName = new("sys.dm_exec_cached_plans");

        public static readonly Column<SqlInt> Bucketid = new("bucketid");

        public static readonly Column<SqlNVarchar> Cacheobjtype = new("cacheobjtype");

        public static readonly Column<SqlVarbinary> MemoryObjectAddress = new("memory_object_address");

        public static readonly Column<SqlNVarchar> Objtype = new("objtype");

        public static readonly Column<SqlVarbinary> ParentPlanHandle = new("parent_plan_handle");

        public static readonly Column<SqlVarbinary> PlanHandle = new("plan_handle");

        public static readonly Column<SqlInt> PoolId = new("pool_id");

        public static readonly Column<SqlInt> Refcounts = new("refcounts");

        public static readonly Column<SqlInt> SizeInBytes = new("size_in_bytes");

        public static readonly Column<SqlInt> Usecounts = new("usecounts");
    }
}
