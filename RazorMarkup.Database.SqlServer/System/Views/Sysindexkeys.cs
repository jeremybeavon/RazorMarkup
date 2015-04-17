using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysIndexKeys
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysindexkeys");
        
        public static readonly Column<SqlSmallInt> Colid = new Column<SqlSmallInt>("colid");
        
        public static readonly Column<SqlInt> Id = new Column<SqlInt>("id");
        
        public static readonly Column<SqlSmallInt> Indid = new Column<SqlSmallInt>("indid");
        
        public static readonly Column<SqlSmallInt> Keyno = new Column<SqlSmallInt>("keyno");
    }
}
