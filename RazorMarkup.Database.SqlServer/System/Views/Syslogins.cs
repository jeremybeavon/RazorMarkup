using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysLogins
    {
        public static readonly ViewName ViewName = new("sys.syslogins");

        public static readonly Column<SqlDateTime> Accdate = new("accdate");

        public static readonly Column<SqlInt> Bulkadmin = new("bulkadmin");

        public static readonly Column<SqlDateTime> Createdate = new("createdate");

        public static readonly Column<SqlInt> Dbcreator = new("dbcreator");

        public static readonly Column<SqlSysname> Dbname = new("dbname");

        public static readonly Column<SqlInt> Denylogin = new("denylogin");

        public static readonly Column<SqlInt> Diskadmin = new("diskadmin");

        public static readonly Column<SqlInt> Hasaccess = new("hasaccess");

        public static readonly Column<SqlInt> Isntgroup = new("isntgroup");

        public static readonly Column<SqlInt> Isntname = new("isntname");

        public static readonly Column<SqlInt> Isntuser = new("isntuser");

        public static readonly Column<SqlSysname> Language = new("language");

        public static readonly Column<SqlSysname> Loginname = new("loginname");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlSysname> Password = new("password");

        public static readonly Column<SqlInt> Processadmin = new("processadmin");

        public static readonly Column<SqlInt> Resultlimit = new("resultlimit");

        public static readonly Column<SqlInt> Securityadmin = new("securityadmin");

        public static readonly Column<SqlInt> Serveradmin = new("serveradmin");

        public static readonly Column<SqlInt> Setupadmin = new("setupadmin");

        public static readonly Column<SqlVarbinary> Sid = new("sid");

        public static readonly Column<SqlInt> Spacelimit = new("spacelimit");

        public static readonly Column<SqlSmallInt> Status = new("status");

        public static readonly Column<SqlInt> Sysadmin = new("sysadmin");

        public static readonly Column<SqlInt> Timelimit = new("timelimit");

        public static readonly Column<SqlInt> Totcpu = new("totcpu");

        public static readonly Column<SqlInt> Totio = new("totio");

        public static readonly Column<SqlDateTime> Updatedate = new("updatedate");
    }
}
