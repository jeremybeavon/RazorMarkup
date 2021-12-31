using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysPermissions
    {
        public static readonly ViewName ViewName = new("sys.syspermissions");

        public static readonly Column<SqlSmallInt> Actadd = new("actadd");

        public static readonly Column<SqlSmallInt> Actmod = new("actmod");

        public static readonly Column<SqlSmallInt> Grantee = new("grantee");

        public static readonly Column<SqlSmallInt> Grantor = new("grantor");

        public static readonly Column<SqlInt> Id = new("id");

        public static readonly Column<SqlVarbinary> Refadd = new("refadd");

        public static readonly Column<SqlVarbinary> Refmod = new("refmod");

        public static readonly Column<SqlVarbinary> Seladd = new("seladd");

        public static readonly Column<SqlVarbinary> Selmod = new("selmod");

        public static readonly Column<SqlVarbinary> Updadd = new("updadd");

        public static readonly Column<SqlVarbinary> Updmod = new("updmod");
    }
}
