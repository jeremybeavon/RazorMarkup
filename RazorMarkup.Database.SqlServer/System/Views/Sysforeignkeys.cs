using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Sysforeignkeys
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysforeignkeys");
        
        public static readonly Column<SqlInt> Constid = new Column<SqlInt>("constid");
        
        public static readonly Column<SqlSmallInt> Fkey = new Column<SqlSmallInt>("fkey");
        
        public static readonly Column<SqlInt> Fkeyid = new Column<SqlInt>("fkeyid");
        
        public static readonly Column<SqlSmallInt> Keyno = new Column<SqlSmallInt>("keyno");
        
        public static readonly Column<SqlSmallInt> Rkey = new Column<SqlSmallInt>("rkey");
        
        public static readonly Column<SqlInt> Rkeyid = new Column<SqlInt>("rkeyid");
    }
}
