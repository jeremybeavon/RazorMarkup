using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class PartitionRangeValues
    {
        public static readonly ViewName ViewName = new ViewName("sys.partition_range_values");
        
        public static readonly Column<SqlInt> BoundaryId = new Column<SqlInt>("boundary_id");
        
        public static readonly Column<SqlInt> FunctionId = new Column<SqlInt>("function_id");
        
        public static readonly Column<SqlInt> ParameterId = new Column<SqlInt>("parameter_id");
        
        public static readonly Column<SqlVariant> Value = new Column<SqlVariant>("value");
    }
}
