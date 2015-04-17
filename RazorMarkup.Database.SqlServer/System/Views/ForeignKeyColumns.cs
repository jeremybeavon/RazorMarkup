using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ForeignKeyColumns
    {
        public static readonly ViewName ViewName = new ViewName("sys.foreign_key_columns");
        
        public static readonly Column<SqlInt> ConstraintColumnId = new Column<SqlInt>("constraint_column_id");
        
        public static readonly Column<SqlInt> ConstraintObjectId = new Column<SqlInt>("constraint_object_id");
        
        public static readonly Column<SqlInt> ParentColumnId = new Column<SqlInt>("parent_column_id");
        
        public static readonly Column<SqlInt> ParentObjectId = new Column<SqlInt>("parent_object_id");
        
        public static readonly Column<SqlInt> ReferencedColumnId = new Column<SqlInt>("referenced_column_id");
        
        public static readonly Column<SqlInt> ReferencedObjectId = new Column<SqlInt>("referenced_object_id");
    }
}
