using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysDatabases
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysdatabases");
        
        public static readonly Column<SqlInt> Category = new Column<SqlInt>("category");
        
        public static readonly Column<SqlTinyInt> Cmptlevel = new Column<SqlTinyInt>("cmptlevel");
        
        public static readonly Column<SqlDateTime> Crdate = new Column<SqlDateTime>("crdate");
        
        public static readonly Column<SqlSmallInt> Dbid = new Column<SqlSmallInt>("dbid");
        
        public static readonly Column<SqlNVarchar> Filename = new Column<SqlNVarchar>("filename");
        
        public static readonly Column<SqlSmallInt> Mode = new Column<SqlSmallInt>("mode");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlDateTime> Reserved = new Column<SqlDateTime>("reserved");
        
        public static readonly Column<SqlVarbinary> Sid = new Column<SqlVarbinary>("sid");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlInt> Status2 = new Column<SqlInt>("status2");
        
        public static readonly Column<SqlSmallInt> Version = new Column<SqlSmallInt>("version");
    }
}
