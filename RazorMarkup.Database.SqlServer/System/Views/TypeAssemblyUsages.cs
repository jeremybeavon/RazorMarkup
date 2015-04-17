using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TypeAssemblyUsages
    {
        public static readonly ViewName ViewName = new ViewName("sys.type_assembly_usages");
        
        public static readonly Column<SqlInt> AssemblyId = new Column<SqlInt>("assembly_id");
        
        public static readonly Column<SqlInt> UserTypeId = new Column<SqlInt>("user_type_id");
    }
}
