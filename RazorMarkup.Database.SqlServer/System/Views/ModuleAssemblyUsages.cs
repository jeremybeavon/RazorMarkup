using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ModuleAssemblyUsages
    {
        public static readonly ViewName ViewName = new ViewName("sys.module_assembly_usages");
        
        public static readonly Column<SqlInt> AssemblyId = new Column<SqlInt>("assembly_id");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
    }
}
