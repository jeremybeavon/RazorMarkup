using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysIndexes
    {
        public static readonly ViewName ViewName = new("sys.sysindexes");

        public static readonly Column<SqlInt> Dpages = new("dpages");

        public static readonly Column<SqlBinary> First = new("first");

        public static readonly Column<SqlBinary> Firstiam = new("FirstIAM");

        public static readonly Column<SqlSmallInt> Groupid = new("groupid");

        public static readonly Column<SqlInt> Id = new("id");

        public static readonly Column<SqlSmallInt> Impid = new("impid");

        public static readonly Column<SqlSmallInt> Indid = new("indid");

        public static readonly Column<SqlSmallInt> Keycnt = new("keycnt");

        public static readonly Column<SqlVarbinary> Keys = new("keys");

        public static readonly Column<SqlSmallInt> Lockflags = new("lockflags");

        public static readonly Column<SqlSmallInt> Maxirow = new("maxirow");

        public static readonly Column<SqlInt> Maxlen = new("maxlen");

        public static readonly Column<SqlSmallInt> Minlen = new("minlen");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlTinyInt> Origfillfactor = new("OrigFillFactor");

        public static readonly Column<SqlInt> Pgmodctr = new("pgmodctr");

        public static readonly Column<SqlInt> Reserved = new("reserved");

        public static readonly Column<SqlInt> Reserved2 = new("reserved2");

        public static readonly Column<SqlTinyInt> Reserved3 = new("reserved3");

        public static readonly Column<SqlTinyInt> Reserved4 = new("reserved4");

        public static readonly Column<SqlBinary> Root = new("root");

        public static readonly Column<SqlBigInt> Rowcnt = new("rowcnt");

        public static readonly Column<SqlInt> Rowmodctr = new("rowmodctr");

        public static readonly Column<SqlInt> Rows = new("rows");

        public static readonly Column<SqlImage> Statblob = new("statblob");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlTinyInt> Statversion = new("StatVersion");

        public static readonly Column<SqlInt> Used = new("used");

        public static readonly Column<SqlSmallInt> Xmaxlen = new("xmaxlen");
    }
}
