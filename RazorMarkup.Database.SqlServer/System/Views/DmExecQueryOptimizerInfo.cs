using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmExecQueryOptimizerInfo
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_exec_query_optimizer_info");
        
        public static readonly Column<SqlNVarchar> Counter = new Column<SqlNVarchar>("counter");
        
        public static readonly Column<SqlBigInt> Occurrence = new Column<SqlBigInt>("occurrence");
        
        public static readonly Column<SqlFloat> Value = new Column<SqlFloat>("value");
    }
}
