using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysMessages
    {
        public static readonly ViewName ViewName = new("sys.sysmessages");

        public static readonly Column<SqlNVarchar> Description = new("description");

        public static readonly Column<SqlSmallInt> Dlevel = new("dlevel");

        public static readonly Column<SqlInt> Error = new("error");

        public static readonly Column<SqlSmallInt> Msglangid = new("msglangid");

        public static readonly Column<SqlTinyInt> Severity = new("severity");
    }
}
