using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeObjects
    {
        public static readonly ViewName ViewName = new("sys.dm_xe_objects");

        public static readonly Column<SqlInt> Capabilities = new("capabilities");

        public static readonly Column<SqlNVarchar> CapabilitiesDesc = new("capabilities_desc");

        public static readonly Column<SqlNVarchar> Description = new("description");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlNVarchar> ObjectType = new("object_type");

        public static readonly Column<SqlUniqueIdentifier> PackageGuid = new("package_guid");

        public static readonly Column<SqlNVarchar> TypeName = new("type_name");

        public static readonly Column<SqlUniqueIdentifier> TypePackageGuid = new("type_package_guid");

        public static readonly Column<SqlInt> TypeSize = new("type_size");
    }
}
