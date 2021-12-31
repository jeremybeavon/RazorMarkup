using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ForeignKeyColumns
    {
        public static readonly ViewName ViewName = new("sys.foreign_key_columns");

        public static readonly Column<SqlInt> ConstraintColumnId = new("constraint_column_id");

        public static readonly Column<SqlInt> ConstraintObjectId = new("constraint_object_id");

        public static readonly Column<SqlInt> ParentColumnId = new("parent_column_id");

        public static readonly Column<SqlInt> ParentObjectId = new("parent_object_id");

        public static readonly Column<SqlInt> ReferencedColumnId = new("referenced_column_id");

        public static readonly Column<SqlInt> ReferencedObjectId = new("referenced_object_id");
    }
}
