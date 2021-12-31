using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXePackages
    {
        public static readonly ViewName ViewName = new("sys.dm_xe_packages");

        public static readonly Column<SqlInt> Capabilities = new("capabilities");

        public static readonly Column<SqlNVarchar> CapabilitiesDesc = new("capabilities_desc");

        public static readonly Column<SqlNVarchar> Description = new("description");

        public static readonly Column<SqlUniqueIdentifier> Guid = new("guid");

        public static readonly Column<SqlVarbinary> ModuleAddress = new("module_address");

        public static readonly Column<SqlNVarchar> ModuleGuid = new("module_guid");

        public static readonly Column<SqlNVarchar> Name = new("name");
    }
}
