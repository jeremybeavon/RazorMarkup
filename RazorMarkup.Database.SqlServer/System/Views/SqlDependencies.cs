using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SqlDependencies
    {
        public static readonly ViewName ViewName = new("sys.sql_dependencies");

        public static readonly Column<SqlTinyInt> Class = new("class");

        public static readonly Column<SqlNVarchar> ClassDesc = new("class_desc");

        public static readonly Column<SqlInt> ColumnId = new("column_id");

        public static readonly Column<SqlBit> IsSelectAll = new("is_select_all");

        public static readonly Column<SqlBit> IsSelected = new("is_selected");

        public static readonly Column<SqlBit> IsUpdated = new("is_updated");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> ReferencedMajorId = new("referenced_major_id");

        public static readonly Column<SqlInt> ReferencedMinorId = new("referenced_minor_id");
    }
}
