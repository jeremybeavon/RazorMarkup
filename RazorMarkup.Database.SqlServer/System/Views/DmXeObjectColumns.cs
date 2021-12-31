using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeObjectColumns
    {
        public static readonly ViewName ViewName = new("sys.dm_xe_object_columns");

        public static readonly Column<SqlInt> Capabilities = new("capabilities");

        public static readonly Column<SqlNVarchar> CapabilitiesDesc = new("capabilities_desc");

        public static readonly Column<SqlInt> ColumnId = new("column_id");

        public static readonly Column<SqlNVarchar> ColumnType = new("column_type");

        public static readonly Column<SqlNVarchar> ColumnValue = new("column_value");

        public static readonly Column<SqlNVarchar> Description = new("description");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlNVarchar> ObjectName = new("object_name");

        public static readonly Column<SqlUniqueIdentifier> ObjectPackageGuid = new("object_package_guid");

        public static readonly Column<SqlNVarchar> TypeName = new("type_name");

        public static readonly Column<SqlUniqueIdentifier> TypePackageGuid = new("type_package_guid");
    }
}
