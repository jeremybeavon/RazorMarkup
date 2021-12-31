using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysFiles
    {
        public static readonly ViewName ViewName = new("sys.sysfiles");

        public static readonly Column<SqlSmallInt> Fileid = new("fileid");

        public static readonly Column<SqlNVarchar> Filename = new("filename");

        public static readonly Column<SqlSmallInt> Groupid = new("groupid");

        public static readonly Column<SqlInt> Growth = new("growth");

        public static readonly Column<SqlInt> Maxsize = new("maxsize");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> Perf = new("perf");

        public static readonly Column<SqlInt> Size = new("size");

        public static readonly Column<SqlInt> Status = new("status");
    }
}
