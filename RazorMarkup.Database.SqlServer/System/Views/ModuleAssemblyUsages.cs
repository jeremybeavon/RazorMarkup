using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ModuleAssemblyUsages
    {
        public static readonly ViewName ViewName = new("sys.module_assembly_usages");

        public static readonly Column<SqlInt> AssemblyId = new("assembly_id");

        public static readonly Column<SqlInt> ObjectId = new("object_id");
    }
}
