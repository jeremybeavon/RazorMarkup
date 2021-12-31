using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysColumns
    {
        public static readonly ViewName ViewName = new("sys.syscolumns");

        public static readonly Column<SqlVarbinary> Autoval = new("autoval");

        public static readonly Column<SqlTinyInt> Bitpos = new("bitpos");

        public static readonly Column<SqlInt> Cdefault = new("cdefault");

        public static readonly Column<SqlSmallInt> Colid = new("colid");

        public static readonly Column<SqlSysname> Collation = new("collation");

        public static readonly Column<SqlInt> Collationid = new("collationid");

        public static readonly Column<SqlSmallInt> Colorder = new("colorder");

        public static readonly Column<SqlSmallInt> Colstat = new("colstat");

        public static readonly Column<SqlInt> Domain = new("domain");

        public static readonly Column<SqlInt> Id = new("id");

        public static readonly Column<SqlInt> Iscomputed = new("iscomputed");

        public static readonly Column<SqlInt> Isnullable = new("isnullable");

        public static readonly Column<SqlInt> Isoutparam = new("isoutparam");

        public static readonly Column<SqlInt> Language = new("language");

        public static readonly Column<SqlSmallInt> Length = new("length");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlSmallInt> Number = new("number");

        public static readonly Column<SqlSmallInt> Offset = new("offset");

        public static readonly Column<SqlSmallInt> Prec = new("prec");

        public static readonly Column<SqlVarchar> Printfmt = new("printfmt");

        public static readonly Column<SqlTinyInt> Reserved = new("reserved");

        public static readonly Column<SqlInt> Scale = new("scale");

        public static readonly Column<SqlTinyInt> Status = new("status");

        public static readonly Column<SqlBinary> Tdscollation = new("tdscollation");

        public static readonly Column<SqlTinyInt> Type = new("type");

        public static readonly Column<SqlTinyInt> Typestat = new("typestat");

        public static readonly Column<SqlSmallInt> Usertype = new("usertype");

        public static readonly Column<SqlSmallInt> Xoffset = new("xoffset");

        public static readonly Column<SqlTinyInt> Xprec = new("xprec");

        public static readonly Column<SqlTinyInt> Xscale = new("xscale");

        public static readonly Column<SqlTinyInt> Xtype = new("xtype");

        public static readonly Column<SqlSmallInt> Xusertype = new("xusertype");
    }
}
