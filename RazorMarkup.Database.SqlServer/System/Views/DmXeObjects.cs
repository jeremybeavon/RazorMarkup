using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeObjects
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_xe_objects");
        
        public static readonly Column<SqlInt> Capabilities = new Column<SqlInt>("capabilities");
        
        public static readonly Column<SqlNVarchar> CapabilitiesDesc = new Column<SqlNVarchar>("capabilities_desc");
        
        public static readonly Column<SqlNVarchar> Description = new Column<SqlNVarchar>("description");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlNVarchar> ObjectType = new Column<SqlNVarchar>("object_type");
        
        public static readonly Column<SqlUniqueIdentifier> PackageGuid = new Column<SqlUniqueIdentifier>("package_guid");
        
        public static readonly Column<SqlNVarchar> TypeName = new Column<SqlNVarchar>("type_name");
        
        public static readonly Column<SqlUniqueIdentifier> TypePackageGuid = new Column<SqlUniqueIdentifier>("type_package_guid");
        
        public static readonly Column<SqlInt> TypeSize = new Column<SqlInt>("type_size");
    }
}
