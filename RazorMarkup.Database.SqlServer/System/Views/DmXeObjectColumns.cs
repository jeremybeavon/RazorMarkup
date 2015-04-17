using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeObjectColumns
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_xe_object_columns");
        
        public static readonly Column<SqlInt> Capabilities = new Column<SqlInt>("capabilities");
        
        public static readonly Column<SqlNVarchar> CapabilitiesDesc = new Column<SqlNVarchar>("capabilities_desc");
        
        public static readonly Column<SqlInt> ColumnId = new Column<SqlInt>("column_id");
        
        public static readonly Column<SqlNVarchar> ColumnType = new Column<SqlNVarchar>("column_type");
        
        public static readonly Column<SqlNVarchar> ColumnValue = new Column<SqlNVarchar>("column_value");
        
        public static readonly Column<SqlNVarchar> Description = new Column<SqlNVarchar>("description");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlNVarchar> ObjectName = new Column<SqlNVarchar>("object_name");
        
        public static readonly Column<SqlUniqueIdentifier> ObjectPackageGuid = new Column<SqlUniqueIdentifier>("object_package_guid");
        
        public static readonly Column<SqlNVarchar> TypeName = new Column<SqlNVarchar>("type_name");
        
        public static readonly Column<SqlUniqueIdentifier> TypePackageGuid = new Column<SqlUniqueIdentifier>("type_package_guid");
    }
}
