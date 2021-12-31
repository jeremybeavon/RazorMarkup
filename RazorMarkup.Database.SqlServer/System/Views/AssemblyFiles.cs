using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AssemblyFiles
    {
        public static readonly ViewName ViewName = new("sys.assembly_files");

        public static readonly Column<SqlInt> AssemblyId = new("assembly_id");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlInt> FileId = new("file_id");

        public static readonly Column<SqlVarbinary> Content = new("content");
    }
}
