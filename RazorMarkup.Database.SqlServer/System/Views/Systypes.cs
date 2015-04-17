using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysTypes
    {
        public static readonly ViewName ViewName = new ViewName("sys.systypes");
        
        public static readonly Column<SqlBit> Allownulls = new Column<SqlBit>("allownulls");
        
        public static readonly Column<SqlSysname> Collation = new Column<SqlSysname>("collation");
        
        public static readonly Column<SqlInt> Collationid = new Column<SqlInt>("collationid");
        
        public static readonly Column<SqlInt> Domain = new Column<SqlInt>("domain");
        
        public static readonly Column<SqlSmallInt> Length = new Column<SqlSmallInt>("length");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlSmallInt> Prec = new Column<SqlSmallInt>("prec");
        
        public static readonly Column<SqlVarchar> Printfmt = new Column<SqlVarchar>("printfmt");
        
        public static readonly Column<SqlSmallInt> Reserved = new Column<SqlSmallInt>("reserved");
        
        public static readonly Column<SqlTinyInt> Scale = new Column<SqlTinyInt>("scale");
        
        public static readonly Column<SqlTinyInt> Status = new Column<SqlTinyInt>("status");
        
        public static readonly Column<SqlInt> Tdefault = new Column<SqlInt>("tdefault");
        
        public static readonly Column<SqlTinyInt> Type = new Column<SqlTinyInt>("type");
        
        public static readonly Column<SqlSmallInt> Uid = new Column<SqlSmallInt>("uid");
        
        public static readonly Column<SqlSmallInt> Usertype = new Column<SqlSmallInt>("usertype");
        
        public static readonly Column<SqlBit> Variable = new Column<SqlBit>("variable");
        
        public static readonly Column<SqlTinyInt> Xprec = new Column<SqlTinyInt>("xprec");
        
        public static readonly Column<SqlTinyInt> Xscale = new Column<SqlTinyInt>("xscale");
        
        public static readonly Column<SqlTinyInt> Xtype = new Column<SqlTinyInt>("xtype");
        
        public static readonly Column<SqlSmallInt> Xusertype = new Column<SqlSmallInt>("xusertype");
    }
}
