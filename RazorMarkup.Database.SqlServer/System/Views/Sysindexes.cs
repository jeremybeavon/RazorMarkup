using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Sysindexes
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysindexes");
        
        public static readonly Column<SqlInt> Dpages = new Column<SqlInt>("dpages");
        
        public static readonly Column<SqlBinary> First = new Column<SqlBinary>("first");
        
        public static readonly Column<SqlBinary> Firstiam = new Column<SqlBinary>("FirstIAM");
        
        public static readonly Column<SqlSmallInt> Groupid = new Column<SqlSmallInt>("groupid");
        
        public static readonly Column<SqlInt> Id = new Column<SqlInt>("id");
        
        public static readonly Column<SqlSmallInt> Impid = new Column<SqlSmallInt>("impid");
        
        public static readonly Column<SqlSmallInt> Indid = new Column<SqlSmallInt>("indid");
        
        public static readonly Column<SqlSmallInt> Keycnt = new Column<SqlSmallInt>("keycnt");
        
        public static readonly Column<SqlVarbinary> Keys = new Column<SqlVarbinary>("keys");
        
        public static readonly Column<SqlSmallInt> Lockflags = new Column<SqlSmallInt>("lockflags");
        
        public static readonly Column<SqlSmallInt> Maxirow = new Column<SqlSmallInt>("maxirow");
        
        public static readonly Column<SqlInt> Maxlen = new Column<SqlInt>("maxlen");
        
        public static readonly Column<SqlSmallInt> Minlen = new Column<SqlSmallInt>("minlen");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlTinyInt> Origfillfactor = new Column<SqlTinyInt>("OrigFillFactor");
        
        public static readonly Column<SqlInt> Pgmodctr = new Column<SqlInt>("pgmodctr");
        
        public static readonly Column<SqlInt> Reserved = new Column<SqlInt>("reserved");
        
        public static readonly Column<SqlInt> Reserved2 = new Column<SqlInt>("reserved2");
        
        public static readonly Column<SqlTinyInt> Reserved3 = new Column<SqlTinyInt>("reserved3");
        
        public static readonly Column<SqlTinyInt> Reserved4 = new Column<SqlTinyInt>("reserved4");
        
        public static readonly Column<SqlBinary> Root = new Column<SqlBinary>("root");
        
        public static readonly Column<SqlBigInt> Rowcnt = new Column<SqlBigInt>("rowcnt");
        
        public static readonly Column<SqlInt> Rowmodctr = new Column<SqlInt>("rowmodctr");
        
        public static readonly Column<SqlInt> Rows = new Column<SqlInt>("rows");
        
        public static readonly Column<SqlImage> Statblob = new Column<SqlImage>("statblob");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlTinyInt> Statversion = new Column<SqlTinyInt>("StatVersion");
        
        public static readonly Column<SqlInt> Used = new Column<SqlInt>("used");
        
        public static readonly Column<SqlSmallInt> Xmaxlen = new Column<SqlSmallInt>("xmaxlen");
    }
}
