using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class PartitionSchemes : DataSpaces
    {
        public new static readonly ViewName ViewName = new ViewName("sys.partition_schemes");

        public static readonly Column<SqlInt> FunctionId = new Column<SqlInt>("function_id");
    }
}
