using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXePackages
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_xe_packages");
        
        public static readonly Column<SqlInt> Capabilities = new Column<SqlInt>("capabilities");
        
        public static readonly Column<SqlNVarchar> CapabilitiesDesc = new Column<SqlNVarchar>("capabilities_desc");
        
        public static readonly Column<SqlNVarchar> Description = new Column<SqlNVarchar>("description");
        
        public static readonly Column<SqlUniqueIdentifier> Guid = new Column<SqlUniqueIdentifier>("guid");
        
        public static readonly Column<SqlVarbinary> ModuleAddress = new Column<SqlVarbinary>("module_address");
        
        public static readonly Column<SqlNVarchar> ModuleGuid = new Column<SqlNVarchar>("module_guid");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
    }
}
