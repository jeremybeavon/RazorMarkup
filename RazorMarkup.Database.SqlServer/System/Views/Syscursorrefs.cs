using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysCursorRefs
    {
        public static readonly ViewName ViewName = new("sys.syscursorrefs");

        public static readonly Column<SqlInt> CursorHandl = new("cursor_handl");

        public static readonly Column<SqlTinyInt> CursorScope = new("cursor_scope");

        public static readonly Column<SqlNVarchar> ReferenceName = new("reference_name");
    }
}
