using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysColumns
    {
        public static readonly ViewName ViewName = new ViewName("sys.syscolumns");
        
        public static readonly Column<SqlVarbinary> Autoval = new Column<SqlVarbinary>("autoval");
        
        public static readonly Column<SqlTinyInt> Bitpos = new Column<SqlTinyInt>("bitpos");
        
        public static readonly Column<SqlInt> Cdefault = new Column<SqlInt>("cdefault");
        
        public static readonly Column<SqlSmallInt> Colid = new Column<SqlSmallInt>("colid");
        
        public static readonly Column<SqlSysname> Collation = new Column<SqlSysname>("collation");
        
        public static readonly Column<SqlInt> Collationid = new Column<SqlInt>("collationid");
        
        public static readonly Column<SqlSmallInt> Colorder = new Column<SqlSmallInt>("colorder");
        
        public static readonly Column<SqlSmallInt> Colstat = new Column<SqlSmallInt>("colstat");
        
        public static readonly Column<SqlInt> Domain = new Column<SqlInt>("domain");
        
        public static readonly Column<SqlInt> Id = new Column<SqlInt>("id");
        
        public static readonly Column<SqlInt> Iscomputed = new Column<SqlInt>("iscomputed");
        
        public static readonly Column<SqlInt> Isnullable = new Column<SqlInt>("isnullable");
        
        public static readonly Column<SqlInt> Isoutparam = new Column<SqlInt>("isoutparam");
        
        public static readonly Column<SqlInt> Language = new Column<SqlInt>("language");
        
        public static readonly Column<SqlSmallInt> Length = new Column<SqlSmallInt>("length");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlSmallInt> Number = new Column<SqlSmallInt>("number");
        
        public static readonly Column<SqlSmallInt> Offset = new Column<SqlSmallInt>("offset");
        
        public static readonly Column<SqlSmallInt> Prec = new Column<SqlSmallInt>("prec");
        
        public static readonly Column<SqlVarchar> Printfmt = new Column<SqlVarchar>("printfmt");
        
        public static readonly Column<SqlTinyInt> Reserved = new Column<SqlTinyInt>("reserved");
        
        public static readonly Column<SqlInt> Scale = new Column<SqlInt>("scale");
        
        public static readonly Column<SqlTinyInt> Status = new Column<SqlTinyInt>("status");
        
        public static readonly Column<SqlBinary> Tdscollation = new Column<SqlBinary>("tdscollation");
        
        public static readonly Column<SqlTinyInt> Type = new Column<SqlTinyInt>("type");
        
        public static readonly Column<SqlTinyInt> Typestat = new Column<SqlTinyInt>("typestat");
        
        public static readonly Column<SqlSmallInt> Usertype = new Column<SqlSmallInt>("usertype");
        
        public static readonly Column<SqlSmallInt> Xoffset = new Column<SqlSmallInt>("xoffset");
        
        public static readonly Column<SqlTinyInt> Xprec = new Column<SqlTinyInt>("xprec");
        
        public static readonly Column<SqlTinyInt> Xscale = new Column<SqlTinyInt>("xscale");
        
        public static readonly Column<SqlTinyInt> Xtype = new Column<SqlTinyInt>("xtype");
        
        public static readonly Column<SqlSmallInt> Xusertype = new Column<SqlSmallInt>("xusertype");
    }
}
