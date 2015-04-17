using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecQueryTransformationStats
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_exec_query_transformation_stats");
        
        public static readonly Column<SqlBigInt> BuiltSubstitute = new Column<SqlBigInt>("built_substitute");
        
        public static readonly Column<SqlVarchar> Name = new Column<SqlVarchar>("name");
        
        public static readonly Column<SqlFloat> PromiseAvg = new Column<SqlFloat>("promise_avg");
        
        public static readonly Column<SqlBigInt> PromiseTotal = new Column<SqlBigInt>("promise_total");
        
        public static readonly Column<SqlBigInt> Promised = new Column<SqlBigInt>("promised");
        
        public static readonly Column<SqlBigInt> Succeeded = new Column<SqlBigInt>("succeeded");
    }
}
