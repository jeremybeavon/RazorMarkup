using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TraceColumns
    {
        public static readonly ViewName ViewName = new("sys.trace_columns");

        public static readonly Column<SqlBit> IsFilterable = new("is_filterable");

        public static readonly Column<SqlBit> IsRepeatable = new("is_repeatable");

        public static readonly Column<SqlBit> IsRepeatedBase = new("is_repeated_base");

        public static readonly Column<SqlInt> MaxSize = new("max_size");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlSmallInt> TraceColumnId = new("trace_column_id");

        public static readonly Column<SqlNVarchar> TypeName = new("type_name");
    }
}
