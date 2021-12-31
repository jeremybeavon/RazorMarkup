using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TraceEvents
    {
        public static readonly ViewName ViewName = new("sys.trace_events");

        public static readonly Column<SqlSmallInt> CategoryId = new("category_id");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlSmallInt> TraceEventId = new("trace_event_id");
    }
}
