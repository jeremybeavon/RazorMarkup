using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Sysdevices
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysdevices");
        
        public static readonly Column<SqlSmallInt> Cntrltype = new Column<SqlSmallInt>("cntrltype");
        
        public static readonly Column<SqlInt> High = new Column<SqlInt>("high");
        
        public static readonly Column<SqlInt> Low = new Column<SqlInt>("low");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlNVarchar> Phyname = new Column<SqlNVarchar>("phyname");
        
        public static readonly Column<SqlInt> Size = new Column<SqlInt>("size");
        
        public static readonly Column<SqlSmallInt> Status = new Column<SqlSmallInt>("status");
    }
}
