using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysFileGroups
    {
        public static readonly ViewName ViewName = new("sys.sysfilegroups");

        public static readonly Column<SqlSmallInt> Allocpolicy = new("allocpolicy");

        public static readonly Column<SqlSmallInt> Groupid = new("groupid");

        public static readonly Column<SqlSysname> Groupname = new("groupname");

        public static readonly Column<SqlInt> Status = new("status");
    }
}
