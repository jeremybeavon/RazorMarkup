using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysFileGroups
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysfilegroups");
        
        public static readonly Column<SqlSmallInt> Allocpolicy = new Column<SqlSmallInt>("allocpolicy");
        
        public static readonly Column<SqlSmallInt> Groupid = new Column<SqlSmallInt>("groupid");
        
        public static readonly Column<SqlSysname> Groupname = new Column<SqlSysname>("groupname");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
    }
}
