using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class AssemblyReferences
    {
        public static readonly ViewName ViewName = new("sys.assembly_references");

        public static readonly Column<SqlInt> AssemblyId = new("assembly_id");

        public static readonly Column<SqlInt> ReferencedAssemblyId = new("referenced_assembly_id");
    }
}
