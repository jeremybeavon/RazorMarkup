using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysForeignKeys
    {
        public static readonly ViewName ViewName = new("sys.sysforeignkeys");

        public static readonly Column<SqlInt> Constid = new("constid");

        public static readonly Column<SqlSmallInt> Fkey = new("fkey");

        public static readonly Column<SqlInt> Fkeyid = new("fkeyid");

        public static readonly Column<SqlSmallInt> Keyno = new("keyno");

        public static readonly Column<SqlSmallInt> Rkey = new("rkey");

        public static readonly Column<SqlInt> Rkeyid = new("rkeyid");
    }
}
