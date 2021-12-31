using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ColumnTypeUsages
    {
        public static readonly ViewName ViewName = new("sys.column_type_usages");

        public static readonly Column<SqlInt> ColumnId = new("column_id");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> UserTypeId = new("user_type_id");
    }
}
