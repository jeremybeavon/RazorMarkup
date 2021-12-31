using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysIndexKeys
    {
        public static readonly ViewName ViewName = new("sys.sysindexkeys");

        public static readonly Column<SqlSmallInt> Colid = new("colid");

        public static readonly Column<SqlInt> Id = new("id");

        public static readonly Column<SqlSmallInt> Indid = new("indid");

        public static readonly Column<SqlSmallInt> Keyno = new("keyno");
    }
}
