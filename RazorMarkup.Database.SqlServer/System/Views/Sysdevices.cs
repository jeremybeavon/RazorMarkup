using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysDevices
    {
        public static readonly ViewName ViewName = new("sys.sysdevices");

        public static readonly Column<SqlSmallInt> Cntrltype = new("cntrltype");

        public static readonly Column<SqlInt> High = new("high");

        public static readonly Column<SqlInt> Low = new("low");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlNVarchar> Phyname = new("phyname");

        public static readonly Column<SqlInt> Size = new("size");

        public static readonly Column<SqlSmallInt> Status = new("status");
    }
}
