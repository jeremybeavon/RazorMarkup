using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysMessages
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysmessages");
        
        public static readonly Column<SqlNVarchar> Description = new Column<SqlNVarchar>("description");
        
        public static readonly Column<SqlSmallInt> Dlevel = new Column<SqlSmallInt>("dlevel");
        
        public static readonly Column<SqlInt> Error = new Column<SqlInt>("error");
        
        public static readonly Column<SqlSmallInt> Msglangid = new Column<SqlSmallInt>("msglangid");
        
        public static readonly Column<SqlTinyInt> Severity = new Column<SqlTinyInt>("severity");
    }
}
