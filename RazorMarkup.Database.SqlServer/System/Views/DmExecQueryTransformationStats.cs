using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecQueryTransformationStats
    {
        public static readonly ViewName ViewName = new("sys.dm_exec_query_transformation_stats");

        public static readonly Column<SqlBigInt> BuiltSubstitute = new("built_substitute");

        public static readonly Column<SqlVarchar> Name = new("name");

        public static readonly Column<SqlFloat> PromiseAvg = new("promise_avg");

        public static readonly Column<SqlBigInt> PromiseTotal = new("promise_total");

        public static readonly Column<SqlBigInt> Promised = new("promised");

        public static readonly Column<SqlBigInt> Succeeded = new("succeeded");
    }
}
