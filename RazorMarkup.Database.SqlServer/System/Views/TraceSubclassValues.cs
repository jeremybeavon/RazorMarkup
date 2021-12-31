using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TraceSubclassValues
    {
        public static readonly ViewName ViewName = new("sys.trace_subclass_values");

        public static readonly Column<SqlNVarchar> SubclassName = new("subclass_name");

        public static readonly Column<SqlSmallInt> SubclassValue = new("subclass_value");

        public static readonly Column<SqlSmallInt> TraceColumnId = new("trace_column_id");

        public static readonly Column<SqlSmallInt> TraceEventId = new("trace_event_id");
    }
}
