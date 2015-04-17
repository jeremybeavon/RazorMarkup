using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeSessionObjectColumns
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_xe_session_object_columns");
        
        public static readonly Column<SqlInt> ColumnId = new Column<SqlInt>("column_id");
        
        public static readonly Column<SqlNVarchar> ColumnName = new Column<SqlNVarchar>("column_name");
        
        public static readonly Column<SqlNVarchar> ColumnValue = new Column<SqlNVarchar>("column_value");
        
        public static readonly Column<SqlVarbinary> EventSessionAddress = new Column<SqlVarbinary>("event_session_address");
        
        public static readonly Column<SqlNVarchar> ObjectName = new Column<SqlNVarchar>("object_name");
        
        public static readonly Column<SqlUniqueIdentifier> ObjectPackageGuid = new Column<SqlUniqueIdentifier>("object_package_guid");
        
        public static readonly Column<SqlNVarchar> ObjectType = new Column<SqlNVarchar>("object_type");
    }
}
