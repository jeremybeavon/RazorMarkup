using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TraceColumns
    {
        public static readonly ViewName ViewName = new ViewName("sys.trace_columns");
        
        public static readonly Column<SqlBit> IsFilterable = new Column<SqlBit>("is_filterable");
        
        public static readonly Column<SqlBit> IsRepeatable = new Column<SqlBit>("is_repeatable");
        
        public static readonly Column<SqlBit> IsRepeatedBase = new Column<SqlBit>("is_repeated_base");
        
        public static readonly Column<SqlInt> MaxSize = new Column<SqlInt>("max_size");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlSmallInt> TraceColumnId = new Column<SqlSmallInt>("trace_column_id");
        
        public static readonly Column<SqlNVarchar> TypeName = new Column<SqlNVarchar>("type_name");
    }
}
