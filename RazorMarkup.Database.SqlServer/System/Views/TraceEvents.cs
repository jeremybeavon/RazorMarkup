using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TraceEvents
    {
        public static readonly ViewName ViewName = new ViewName("sys.trace_events");
        
        public static readonly Column<SqlSmallInt> CategoryId = new Column<SqlSmallInt>("category_id");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlSmallInt> TraceEventId = new Column<SqlSmallInt>("trace_event_id");
    }
}
