using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TraceSubclassValues
    {
        public static readonly ViewName ViewName = new ViewName("sys.trace_subclass_values");
        
        public static readonly Column<SqlNVarchar> SubclassName = new Column<SqlNVarchar>("subclass_name");
        
        public static readonly Column<SqlSmallInt> SubclassValue = new Column<SqlSmallInt>("subclass_value");
        
        public static readonly Column<SqlSmallInt> TraceColumnId = new Column<SqlSmallInt>("trace_column_id");
        
        public static readonly Column<SqlSmallInt> TraceEventId = new Column<SqlSmallInt>("trace_event_id");
    }
}
