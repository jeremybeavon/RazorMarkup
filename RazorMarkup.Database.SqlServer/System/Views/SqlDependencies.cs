using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SqlDependencies
    {
        public static readonly ViewName ViewName = new ViewName("sys.sql_dependencies");
        
        public static readonly Column<SqlTinyInt> Class = new Column<SqlTinyInt>("class");
        
        public static readonly Column<SqlNVarchar> ClassDesc = new Column<SqlNVarchar>("class_desc");
        
        public static readonly Column<SqlInt> ColumnId = new Column<SqlInt>("column_id");
        
        public static readonly Column<SqlBit> IsSelectAll = new Column<SqlBit>("is_select_all");
        
        public static readonly Column<SqlBit> IsSelected = new Column<SqlBit>("is_selected");
        
        public static readonly Column<SqlBit> IsUpdated = new Column<SqlBit>("is_updated");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> ReferencedMajorId = new Column<SqlInt>("referenced_major_id");
        
        public static readonly Column<SqlInt> ReferencedMinorId = new Column<SqlInt>("referenced_minor_id");
    }
}
