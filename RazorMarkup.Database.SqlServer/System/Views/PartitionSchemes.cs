using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class PartitionSchemes : DataSpaces
    {
        public static new readonly ViewName ViewName = new("sys.partition_schemes");

        public static readonly Column<SqlInt> FunctionId = new("function_id");
    }
}
