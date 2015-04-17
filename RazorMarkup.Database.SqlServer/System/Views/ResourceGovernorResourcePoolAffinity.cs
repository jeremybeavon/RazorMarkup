using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ResourceGovernorResourcePoolAffinity
    {
        public static readonly ViewName ViewName = new ViewName("sys.resource_governor_resource_pool_affinity");
        
        public static readonly Column<SqlInt> PoolId = new Column<SqlInt>("pool_id");
        
        public static readonly Column<SqlSmallInt> ProcessorGroup = new Column<SqlSmallInt>("processor_group");
        
        public static readonly Column<SqlBigInt> SchedulerMask = new Column<SqlBigInt>("scheduler_mask");
    }
}
