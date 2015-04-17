using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsPerformanceCounters
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_performance_counters");
        
        public static readonly Column<SqlInt> CntrType = new Column<SqlInt>("cntr_type");
        
        public static readonly Column<SqlBigInt> CntrValue = new Column<SqlBigInt>("cntr_value");
        
        public static readonly Column<SqlNChar> CounterName = new Column<SqlNChar>("counter_name");
        
        public static readonly Column<SqlNChar> InstanceName = new Column<SqlNChar>("instance_name");
        
        public static readonly Column<SqlNChar> ObjectName = new Column<SqlNChar>("object_name");
    }
}
