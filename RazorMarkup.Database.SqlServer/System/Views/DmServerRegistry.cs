using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmServerRegistry
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_server_registry");
        
        public static readonly Column<SqlNVarchar> RegistryKey = new Column<SqlNVarchar>("registry_key");
        
        public static readonly Column<SqlVariant> ValueData = new Column<SqlVariant>("value_data");
        
        public static readonly Column<SqlNVarchar> ValueName = new Column<SqlNVarchar>("value_name");
    }
}
