using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysCursorColumns
    {
        public static readonly ViewName ViewName = new ViewName("sys.syscursorcolumns");
        
        public static readonly Column<SqlInt> ColumnCharacteristicsFlags = new Column<SqlInt>("column_characteristics_flags");
        
        public static readonly Column<SqlNVarchar> ColumnName = new Column<SqlNVarchar>("column_name");
        
        public static readonly Column<SqlTinyInt> ColumnPrecision = new Column<SqlTinyInt>("column_precision");
        
        public static readonly Column<SqlTinyInt> ColumnScale = new Column<SqlTinyInt>("column_scale");
        
        public static readonly Column<SqlInt> ColumnSize = new Column<SqlInt>("column_size");
        
        public static readonly Column<SqlInt> Columnid = new Column<SqlInt>("columnid");
        
        public static readonly Column<SqlInt> CursorHandle = new Column<SqlInt>("cursor_handle");
        
        public static readonly Column<SqlInt> DataTypeSql = new Column<SqlInt>("data_type_sql");
        
        public static readonly Column<SqlInt> Dbid = new Column<SqlInt>("dbid");
        
        public static readonly Column<SqlNVarchar> Dbname = new Column<SqlNVarchar>("dbname");
        
        public static readonly Column<SqlSmallInt> HiddenColumn = new Column<SqlSmallInt>("hidden_column");
        
        public static readonly Column<SqlInt> Objectid = new Column<SqlInt>("objectid");
        
        public static readonly Column<SqlNVarchar> OrderDirection = new Column<SqlNVarchar>("order_direction");
        
        public static readonly Column<SqlInt> OrderPosition = new Column<SqlInt>("order_position");
        
        public static readonly Column<SqlInt> OrdinalPosition = new Column<SqlInt>("ordinal_position");
    }
}
