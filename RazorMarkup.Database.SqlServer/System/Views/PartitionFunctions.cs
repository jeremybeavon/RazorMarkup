using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class PartitionFunctions
    {
        public static readonly ViewName ViewName = new("sys.partition_functions");

        public static readonly Column<SqlBit> BoundaryValueOnRight = new("boundary_value_on_right");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlInt> Fanout = new("fanout");

        public static readonly Column<SqlInt> FunctionId = new("function_id");

        public static readonly Column<SqlBit> IsSystem = new("is_system");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlChar> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
