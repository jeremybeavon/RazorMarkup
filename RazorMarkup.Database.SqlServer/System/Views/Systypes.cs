using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysTypes
    {
        public static readonly ViewName ViewName = new("sys.systypes");

        public static readonly Column<SqlBit> Allownulls = new("allownulls");

        public static readonly Column<SqlSysname> Collation = new("collation");

        public static readonly Column<SqlInt> Collationid = new("collationid");

        public static readonly Column<SqlInt> Domain = new("domain");

        public static readonly Column<SqlSmallInt> Length = new("length");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlSmallInt> Prec = new("prec");

        public static readonly Column<SqlVarchar> Printfmt = new("printfmt");

        public static readonly Column<SqlSmallInt> Reserved = new("reserved");

        public static readonly Column<SqlTinyInt> Scale = new("scale");

        public static readonly Column<SqlTinyInt> Status = new("status");

        public static readonly Column<SqlInt> Tdefault = new("tdefault");

        public static readonly Column<SqlTinyInt> Type = new("type");

        public static readonly Column<SqlSmallInt> Uid = new("uid");

        public static readonly Column<SqlSmallInt> Usertype = new("usertype");

        public static readonly Column<SqlBit> Variable = new("variable");

        public static readonly Column<SqlTinyInt> Xprec = new("xprec");

        public static readonly Column<SqlTinyInt> Xscale = new("xscale");

        public static readonly Column<SqlTinyInt> Xtype = new("xtype");

        public static readonly Column<SqlSmallInt> Xusertype = new("xusertype");
    }
}
