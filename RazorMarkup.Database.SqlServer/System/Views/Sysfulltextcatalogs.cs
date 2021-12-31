using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysFullTextCatalogs
    {
        public static readonly ViewName ViewName = new("sys.sysfulltextcatalogs");

        public static readonly Column<SqlSmallInt> Ftcatid = new("ftcatid");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlNVarchar> Path = new("path");

        public static readonly Column<SqlSmallInt> Status = new("status");
    }
}
