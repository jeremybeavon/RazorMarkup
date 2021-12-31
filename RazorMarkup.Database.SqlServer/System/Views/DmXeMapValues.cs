using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeMapValues
    {
        public static readonly ViewName ViewName = new("sys.dm_xe_map_values");

        public static readonly Column<SqlInt> MapKey = new("map_key");

        public static readonly Column<SqlNVarchar> MapValue = new("map_value");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlUniqueIdentifier> ObjectPackageGuid = new("object_package_guid");
    }
}
