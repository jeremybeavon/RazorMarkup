using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Sysremotelogins
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysremotelogins");
        
        public static readonly Column<SqlDateTime> Changedate = new Column<SqlDateTime>("changedate");
        
        public static readonly Column<SqlSmallInt> Remoteserverid = new Column<SqlSmallInt>("remoteserverid");
        
        public static readonly Column<SqlSysname> Remoteusername = new Column<SqlSysname>("remoteusername");
        
        public static readonly Column<SqlVarbinary> Sid = new Column<SqlVarbinary>("sid");
        
        public static readonly Column<SqlSmallInt> Status = new Column<SqlSmallInt>("status");
    }
}
