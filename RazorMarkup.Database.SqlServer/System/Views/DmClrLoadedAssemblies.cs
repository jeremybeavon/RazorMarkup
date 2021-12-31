using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmClrLoadedAssemblies
    {
        public static readonly ViewName ViewName = new("sys.dm_clr_loaded_assemblies");

        public static readonly Column<SqlVarbinary> AppdomainAddress = new("appdomain_address");

        public static readonly Column<SqlInt> AssemblyId = new("assembly_id");

        public static readonly Column<SqlDateTime> LoadTime = new("load_time");
    }
}
