using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysOleDbUsers
    {
        public static readonly ViewName ViewName = new("sys.sysoledbusers");

        public static readonly Column<SqlDateTime> Changedate = new("changedate");

        public static readonly Column<SqlVarbinary> Loginsid = new("loginsid");

        public static readonly Column<SqlSysname> Rmtloginame = new("rmtloginame");

        public static readonly Column<SqlSysname> Rmtpassword = new("rmtpassword");

        public static readonly Column<SqlSmallInt> Rmtsrvid = new("rmtsrvid");

        public static readonly Column<SqlSmallInt> Status = new("status");
    }
}
