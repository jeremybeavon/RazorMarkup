using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysUsers
    {
        public static readonly ViewName ViewName = new("sys.sysusers");

        public static readonly Column<SqlSmallInt> Altuid = new("altuid");

        public static readonly Column<SqlDateTime> Createdate = new("createdate");

        public static readonly Column<SqlVarchar> Environ = new("environ");

        public static readonly Column<SqlSmallInt> Gid = new("gid");

        public static readonly Column<SqlInt> Hasdbaccess = new("hasdbaccess");

        public static readonly Column<SqlInt> Isaliased = new("isaliased");

        public static readonly Column<SqlInt> Isapprole = new("isapprole");

        public static readonly Column<SqlInt> Islogin = new("islogin");

        public static readonly Column<SqlInt> Isntgroup = new("isntgroup");

        public static readonly Column<SqlInt> Isntname = new("isntname");

        public static readonly Column<SqlInt> Isntuser = new("isntuser");

        public static readonly Column<SqlInt> Issqlrole = new("issqlrole");

        public static readonly Column<SqlInt> Issqluser = new("issqluser");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlVarbinary> Password = new("password");

        public static readonly Column<SqlVarbinary> Roles = new("roles");

        public static readonly Column<SqlVarbinary> Sid = new("sid");

        public static readonly Column<SqlSmallInt> Status = new("status");

        public static readonly Column<SqlSmallInt> Uid = new("uid");

        public static readonly Column<SqlDateTime> Updatedate = new("updatedate");
    }
}
