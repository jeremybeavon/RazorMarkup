using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Syscursors
    {
        public static readonly ViewName ViewName = new ViewName("sys.syscursors");
        
        public static readonly Column<SqlSmallInt> ColumnCount = new Column<SqlSmallInt>("column_count");
        
        public static readonly Column<SqlTinyInt> Concurrency = new Column<SqlTinyInt>("concurrency");
        
        public static readonly Column<SqlInt> CursorHandle = new Column<SqlInt>("cursor_handle");
        
        public static readonly Column<SqlNVarchar> CursorName = new Column<SqlNVarchar>("cursor_name");
        
        public static readonly Column<SqlNumeric> CursorRows = new Column<SqlNumeric>("cursor_rows");
        
        public static readonly Column<SqlSmallInt> FetchStatus = new Column<SqlSmallInt>("fetch_status");
        
        public static readonly Column<SqlTinyInt> LastOperation = new Column<SqlTinyInt>("last_operation");
        
        public static readonly Column<SqlTinyInt> Model = new Column<SqlTinyInt>("model");
        
        public static readonly Column<SqlTinyInt> OpenStatus = new Column<SqlTinyInt>("open_status");
        
        public static readonly Column<SqlNumeric> RowCount = new Column<SqlNumeric>("row_count");
        
        public static readonly Column<SqlTinyInt> Scrollable = new Column<SqlTinyInt>("scrollable");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
    }
}
