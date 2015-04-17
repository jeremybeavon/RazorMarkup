using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysOleDbUsers
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysoledbusers");
        
        public static readonly Column<SqlDateTime> Changedate = new Column<SqlDateTime>("changedate");
        
        public static readonly Column<SqlVarbinary> Loginsid = new Column<SqlVarbinary>("loginsid");
        
        public static readonly Column<SqlSysname> Rmtloginame = new Column<SqlSysname>("rmtloginame");
        
        public static readonly Column<SqlSysname> Rmtpassword = new Column<SqlSysname>("rmtpassword");
        
        public static readonly Column<SqlSmallInt> Rmtsrvid = new Column<SqlSmallInt>("rmtsrvid");
        
        public static readonly Column<SqlSmallInt> Status = new Column<SqlSmallInt>("status");
    }
}
