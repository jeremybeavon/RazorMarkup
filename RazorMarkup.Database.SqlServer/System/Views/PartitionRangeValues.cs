using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class PartitionRangeValues
    {
        public static readonly ViewName ViewName = new("sys.partition_range_values");

        public static readonly Column<SqlInt> BoundaryId = new("boundary_id");

        public static readonly Column<SqlInt> FunctionId = new("function_id");

        public static readonly Column<SqlInt> ParameterId = new("parameter_id");

        public static readonly Column<SqlVariant> Value = new("value");
    }
}
