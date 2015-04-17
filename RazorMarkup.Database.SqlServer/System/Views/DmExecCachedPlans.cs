using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecCachedPlans
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_exec_cached_plans");
        
        public static readonly Column<SqlInt> Bucketid = new Column<SqlInt>("bucketid");
        
        public static readonly Column<SqlNVarchar> Cacheobjtype = new Column<SqlNVarchar>("cacheobjtype");
        
        public static readonly Column<SqlVarbinary> MemoryObjectAddress = new Column<SqlVarbinary>("memory_object_address");
        
        public static readonly Column<SqlNVarchar> Objtype = new Column<SqlNVarchar>("objtype");
        
        public static readonly Column<SqlVarbinary> ParentPlanHandle = new Column<SqlVarbinary>("parent_plan_handle");
        
        public static readonly Column<SqlVarbinary> PlanHandle = new Column<SqlVarbinary>("plan_handle");
        
        public static readonly Column<SqlInt> PoolId = new Column<SqlInt>("pool_id");
        
        public static readonly Column<SqlInt> Refcounts = new Column<SqlInt>("refcounts");
        
        public static readonly Column<SqlInt> SizeInBytes = new Column<SqlInt>("size_in_bytes");
        
        public static readonly Column<SqlInt> Usecounts = new Column<SqlInt>("usecounts");
    }
}
