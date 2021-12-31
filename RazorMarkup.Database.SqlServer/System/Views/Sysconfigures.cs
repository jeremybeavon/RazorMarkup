using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysConfigures
    {
        public static readonly ViewName ViewName = new("sys.sysconfigures");

        public static readonly Column<SqlNVarchar> Comment = new("comment");

        public static readonly Column<SqlInt> Config = new("config");

        public static readonly Column<SqlSmallInt> Status = new("status");

        public static readonly Column<SqlInt> Value = new("value");
    }
}
