using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysCursorColumns
    {
        public static readonly ViewName ViewName = new("sys.syscursorcolumns");

        public static readonly Column<SqlInt> ColumnCharacteristicsFlags = new("column_characteristics_flags");

        public static readonly Column<SqlNVarchar> ColumnName = new("column_name");

        public static readonly Column<SqlTinyInt> ColumnPrecision = new("column_precision");

        public static readonly Column<SqlTinyInt> ColumnScale = new("column_scale");

        public static readonly Column<SqlInt> ColumnSize = new("column_size");

        public static readonly Column<SqlInt> Columnid = new("columnid");

        public static readonly Column<SqlInt> CursorHandle = new("cursor_handle");

        public static readonly Column<SqlInt> DataTypeSql = new("data_type_sql");

        public static readonly Column<SqlInt> Dbid = new("dbid");

        public static readonly Column<SqlNVarchar> Dbname = new("dbname");

        public static readonly Column<SqlSmallInt> HiddenColumn = new("hidden_column");

        public static readonly Column<SqlInt> Objectid = new("objectid");

        public static readonly Column<SqlNVarchar> OrderDirection = new("order_direction");

        public static readonly Column<SqlInt> OrderPosition = new("order_position");

        public static readonly Column<SqlInt> OrdinalPosition = new("ordinal_position");
    }
}
