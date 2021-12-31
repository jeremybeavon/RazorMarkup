using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmResourceGovernorResourcePoolAffinity
    {
        public static readonly ViewName ViewName = new("sys.dm_resource_governor_resource_pool_affinity");

        public static readonly Column<SqlInt> PoolId = new("pool_id");

        public static readonly Column<SqlSmallInt> ProcessorGroup = new("processor_group");

        public static readonly Column<SqlBigInt> SchedulerMask = new("scheduler_mask");
    }
}
