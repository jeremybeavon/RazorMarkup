using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeMapValues
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_xe_map_values");
        
        public static readonly Column<SqlInt> MapKey = new Column<SqlInt>("map_key");
        
        public static readonly Column<SqlNVarchar> MapValue = new Column<SqlNVarchar>("map_value");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlUniqueIdentifier> ObjectPackageGuid = new Column<SqlUniqueIdentifier>("object_package_guid");
    }
}
