using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysDepends
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysdepends");
        
        public static readonly Column<SqlSmallInt> Depdbid = new Column<SqlSmallInt>("depdbid");
        
        public static readonly Column<SqlInt> Depid = new Column<SqlInt>("depid");
        
        public static readonly Column<SqlSmallInt> Depnumber = new Column<SqlSmallInt>("depnumber");
        
        public static readonly Column<SqlSmallInt> Depsiteid = new Column<SqlSmallInt>("depsiteid");
        
        public static readonly Column<SqlTinyInt> Deptype = new Column<SqlTinyInt>("deptype");
        
        public static readonly Column<SqlInt> Id = new Column<SqlInt>("id");
        
        public static readonly Column<SqlSmallInt> Number = new Column<SqlSmallInt>("number");
        
        public static readonly Column<SqlBit> Readobj = new Column<SqlBit>("readobj");
        
        public static readonly Column<SqlBit> Resultobj = new Column<SqlBit>("resultobj");
        
        public static readonly Column<SqlBit> Selall = new Column<SqlBit>("selall");
        
        public static readonly Column<SqlSmallInt> Status = new Column<SqlSmallInt>("status");
    }
}
