using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Filetables
    {
        public static readonly ViewName ViewName = new("sys.filetables");

        public static readonly Column<SqlNVarchar> DirectoryName = new("directory_name");

        public static readonly Column<SqlInt> FilenameCollationId = new("filename_collation_id");

        public static readonly Column<SqlNVarchar> FilenameCollationName = new("filename_collation_name");

        public static readonly Column<SqlBit> IsEnabled = new("is_enabled");

        public static readonly Column<SqlInt> ObjectId = new("object_id");
    }
}
