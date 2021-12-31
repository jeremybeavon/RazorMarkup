using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmServerRegistry
    {
        public static readonly ViewName ViewName = new("sys.dm_server_registry");

        public static readonly Column<SqlNVarchar> RegistryKey = new("registry_key");

        public static readonly Column<SqlVariant> ValueData = new("value_data");

        public static readonly Column<SqlNVarchar> ValueName = new("value_name");
    }
}
