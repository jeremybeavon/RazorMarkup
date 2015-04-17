using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Syscurconfigs
    {
        public static readonly ViewName ViewName = new ViewName("sys.syscurconfigs");
        
        public static readonly Column<SqlNVarchar> Comment = new Column<SqlNVarchar>("comment");
        
        public static readonly Column<SqlSmallInt> Config = new Column<SqlSmallInt>("config");
        
        public static readonly Column<SqlSmallInt> Status = new Column<SqlSmallInt>("status");
        
        public static readonly Column<SqlInt> Value = new Column<SqlInt>("value");
    }
}
