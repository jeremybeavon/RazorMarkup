using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysFullTextCatalogs
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysfulltextcatalogs");
        
        public static readonly Column<SqlSmallInt> Ftcatid = new Column<SqlSmallInt>("ftcatid");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlNVarchar> Path = new Column<SqlNVarchar>("path");
        
        public static readonly Column<SqlSmallInt> Status = new Column<SqlSmallInt>("status");
    }
}
