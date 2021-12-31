using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsPerformanceCounters
    {
        public static readonly ViewName ViewName = new("sys.dm_os_performance_counters");

        public static readonly Column<SqlInt> CntrType = new("cntr_type");

        public static readonly Column<SqlBigInt> CntrValue = new("cntr_value");

        public static readonly Column<SqlNChar> CounterName = new("counter_name");

        public static readonly Column<SqlNChar> InstanceName = new("instance_name");

        public static readonly Column<SqlNChar> ObjectName = new("object_name");
    }
}
