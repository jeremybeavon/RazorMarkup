using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmClrLoadedAssemblies
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_clr_loaded_assemblies");
        
        public static readonly Column<SqlVarbinary> AppdomainAddress = new Column<SqlVarbinary>("appdomain_address");
        
        public static readonly Column<SqlInt> AssemblyId = new Column<SqlInt>("assembly_id");
        
        public static readonly Column<SqlDateTime> LoadTime = new Column<SqlDateTime>("load_time");
    }
}
