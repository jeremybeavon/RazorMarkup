using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Filetables
    {
        public static readonly ViewName ViewName = new ViewName("sys.filetables");
        
        public static readonly Column<SqlNVarchar> DirectoryName = new Column<SqlNVarchar>("directory_name");
        
        public static readonly Column<SqlInt> FilenameCollationId = new Column<SqlInt>("filename_collation_id");
        
        public static readonly Column<SqlNVarchar> FilenameCollationName = new Column<SqlNVarchar>("filename_collation_name");
        
        public static readonly Column<SqlBit> IsEnabled = new Column<SqlBit>("is_enabled");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
    }
}
