using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TraceEventBindings
    {
        public static readonly ViewName ViewName = new ViewName("sys.trace_event_bindings");
        
        public static readonly Column<SqlSmallInt> TraceColumnId = new Column<SqlSmallInt>("trace_column_id");
        
        public static readonly Column<SqlSmallInt> TraceEventId = new Column<SqlSmallInt>("trace_event_id");
    }
}
