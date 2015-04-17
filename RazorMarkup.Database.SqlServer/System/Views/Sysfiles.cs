using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Sysfiles
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysfiles");
        
        public static readonly Column<SqlSmallInt> Fileid = new Column<SqlSmallInt>("fileid");
        
        public static readonly Column<SqlNVarchar> Filename = new Column<SqlNVarchar>("filename");
        
        public static readonly Column<SqlSmallInt> Groupid = new Column<SqlSmallInt>("groupid");
        
        public static readonly Column<SqlInt> Growth = new Column<SqlInt>("growth");
        
        public static readonly Column<SqlInt> Maxsize = new Column<SqlInt>("maxsize");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> Perf = new Column<SqlInt>("perf");
        
        public static readonly Column<SqlInt> Size = new Column<SqlInt>("size");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
    }
}
