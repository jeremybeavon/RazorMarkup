using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeSessionObjectColumns
    {
        public static readonly ViewName ViewName = new("sys.dm_xe_session_object_columns");

        public static readonly Column<SqlInt> ColumnId = new("column_id");

        public static readonly Column<SqlNVarchar> ColumnName = new("column_name");

        public static readonly Column<SqlNVarchar> ColumnValue = new("column_value");

        public static readonly Column<SqlVarbinary> EventSessionAddress = new("event_session_address");

        public static readonly Column<SqlNVarchar> ObjectName = new("object_name");

        public static readonly Column<SqlUniqueIdentifier> ObjectPackageGuid = new("object_package_guid");

        public static readonly Column<SqlNVarchar> ObjectType = new("object_type");
    }
}
