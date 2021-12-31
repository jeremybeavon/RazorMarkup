using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FunctionOrderColumns
    {
        public static readonly ViewName ViewName = new("sys.function_order_columns");

        public static readonly Column<SqlInt> ColumnId = new("column_id");

        public static readonly Column<SqlBit> IsDescending = new("is_descending");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> OrderColumnId = new("order_column_id");
    }
}
