using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class AssemblyModules
    {
        public static readonly ViewName ViewName = new ViewName("sys.assembly_modules");
        
        public static readonly Column<SqlNVarchar> AssemblyClass = new Column<SqlNVarchar>("assembly_class");
        
        public static readonly Column<SqlInt> AssemblyId = new Column<SqlInt>("assembly_id");
        
        public static readonly Column<SqlNVarchar> AssemblyMethod = new Column<SqlNVarchar>("assembly_method");
        
        public static readonly Column<SqlInt> ExecuteAsPrincipalId = new Column<SqlInt>("execute_as_principal_id");
        
        public static readonly Column<SqlBit> NullOnNullInput = new Column<SqlBit>("null_on_null_input");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
    }
}
