using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AssemblyFiles
    {
        public static readonly ViewName ViewName = new ViewName("sys.assembly_files");

        public static readonly Column<SqlInt> AssemblyId = new Column<SqlInt>("assembly_id");

        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");

        public static readonly Column<SqlInt> FileId = new Column<SqlInt>("file_id");

        public static readonly Column<SqlVarbinary> Content = new Column<SqlVarbinary>("content");
    }
}
