using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysDatabases
    {
        public static readonly ViewName ViewName = new("sys.sysdatabases");

        public static readonly Column<SqlInt> Category = new("category");

        public static readonly Column<SqlTinyInt> Cmptlevel = new("cmptlevel");

        public static readonly Column<SqlDateTime> Crdate = new("crdate");

        public static readonly Column<SqlSmallInt> Dbid = new("dbid");

        public static readonly Column<SqlNVarchar> Filename = new("filename");

        public static readonly Column<SqlSmallInt> Mode = new("mode");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlDateTime> Reserved = new("reserved");

        public static readonly Column<SqlVarbinary> Sid = new("sid");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlInt> Status2 = new("status2");

        public static readonly Column<SqlSmallInt> Version = new("version");
    }
}
