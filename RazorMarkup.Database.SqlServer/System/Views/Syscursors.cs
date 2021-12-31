using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysCursors
    {
        public static readonly ViewName ViewName = new("sys.syscursors");

        public static readonly Column<SqlSmallInt> ColumnCount = new("column_count");

        public static readonly Column<SqlTinyInt> Concurrency = new("concurrency");

        public static readonly Column<SqlInt> CursorHandle = new("cursor_handle");

        public static readonly Column<SqlNVarchar> CursorName = new("cursor_name");

        public static readonly Column<SqlNumeric> CursorRows = new("cursor_rows");

        public static readonly Column<SqlSmallInt> FetchStatus = new("fetch_status");

        public static readonly Column<SqlTinyInt> LastOperation = new("last_operation");

        public static readonly Column<SqlTinyInt> Model = new("model");

        public static readonly Column<SqlTinyInt> OpenStatus = new("open_status");

        public static readonly Column<SqlNumeric> RowCount = new("row_count");

        public static readonly Column<SqlTinyInt> Scrollable = new("scrollable");

        public static readonly Column<SqlInt> Status = new("status");
    }
}
