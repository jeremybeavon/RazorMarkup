using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class AssemblyModules
    {
        public static readonly ViewName ViewName = new("sys.assembly_modules");

        public static readonly Column<SqlNVarchar> AssemblyClass = new("assembly_class");

        public static readonly Column<SqlInt> AssemblyId = new("assembly_id");

        public static readonly Column<SqlNVarchar> AssemblyMethod = new("assembly_method");

        public static readonly Column<SqlInt> ExecuteAsPrincipalId = new("execute_as_principal_id");

        public static readonly Column<SqlBit> NullOnNullInput = new("null_on_null_input");

        public static readonly Column<SqlInt> ObjectId = new("object_id");
    }
}
