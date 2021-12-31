using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysProtects
    {
        public static readonly ViewName ViewName = new("sys.sysprotects");

        public static readonly Column<SqlTinyInt> Action = new("action");

        public static readonly Column<SqlVarbinary> Columns = new("columns");

        public static readonly Column<SqlSmallInt> Grantor = new("grantor");

        public static readonly Column<SqlInt> Id = new("id");

        public static readonly Column<SqlTinyInt> Protecttype = new("protecttype");

        public static readonly Column<SqlSmallInt> Uid = new("uid");
    }
}
