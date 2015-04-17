using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Sysopentapes
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysopentapes");
        
        public static readonly Column<SqlNVarchar> Opentape = new Column<SqlNVarchar>("openTape");
    }
}
