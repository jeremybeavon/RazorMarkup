using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FunctionOrderColumns
    {
        public static readonly ViewName ViewName = new ViewName("sys.function_order_columns");
        
        public static readonly Column<SqlInt> ColumnId = new Column<SqlInt>("column_id");
        
        public static readonly Column<SqlBit> IsDescending = new Column<SqlBit>("is_descending");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> OrderColumnId = new Column<SqlInt>("order_column_id");
    }
}
