using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TypeAssemblyUsages
    {
        public static readonly ViewName ViewName = new("sys.type_assembly_usages");

        public static readonly Column<SqlInt> AssemblyId = new("assembly_id");

        public static readonly Column<SqlInt> UserTypeId = new("user_type_id");
    }
}
