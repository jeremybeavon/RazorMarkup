using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class PartitionFunctions
    {
        public static readonly ViewName ViewName = new ViewName("sys.partition_functions");
        
        public static readonly Column<SqlBit> BoundaryValueOnRight = new Column<SqlBit>("boundary_value_on_right");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlInt> Fanout = new Column<SqlInt>("fanout");
        
        public static readonly Column<SqlInt> FunctionId = new Column<SqlInt>("function_id");
        
        public static readonly Column<SqlBit> IsSystem = new Column<SqlBit>("is_system");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlChar> Type = new Column<SqlChar>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
    }
}
