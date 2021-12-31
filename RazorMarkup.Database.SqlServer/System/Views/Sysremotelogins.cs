using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysRemoteLogins
    {
        public static readonly ViewName ViewName = new("sys.sysremotelogins");

        public static readonly Column<SqlDateTime> Changedate = new("changedate");

        public static readonly Column<SqlSmallInt> Remoteserverid = new("remoteserverid");

        public static readonly Column<SqlSysname> Remoteusername = new("remoteusername");

        public static readonly Column<SqlVarbinary> Sid = new("sid");

        public static readonly Column<SqlSmallInt> Status = new("status");
    }
}
