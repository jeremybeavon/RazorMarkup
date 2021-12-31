using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecQueryOptimizerInfo
    {
        public static readonly ViewName ViewName = new("sys.dm_exec_query_optimizer_info");

        public static readonly Column<SqlNVarchar> Counter = new("counter");

        public static readonly Column<SqlBigInt> Occurrence = new("occurrence");

        public static readonly Column<SqlFloat> Value = new("value");
    }
}
