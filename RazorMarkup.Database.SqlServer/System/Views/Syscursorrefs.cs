using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Syscursorrefs
    {
        public static readonly ViewName ViewName = new ViewName("sys.syscursorrefs");
        
        public static readonly Column<SqlInt> CursorHandl = new Column<SqlInt>("cursor_handl");
        
        public static readonly Column<SqlTinyInt> CursorScope = new Column<SqlTinyInt>("cursor_scope");
        
        public static readonly Column<SqlNVarchar> ReferenceName = new Column<SqlNVarchar>("reference_name");
    }
}
