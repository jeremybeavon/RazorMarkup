using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysProtects
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysprotects");
        
        public static readonly Column<SqlTinyInt> Action = new Column<SqlTinyInt>("action");
        
        public static readonly Column<SqlVarbinary> Columns = new Column<SqlVarbinary>("columns");
        
        public static readonly Column<SqlSmallInt> Grantor = new Column<SqlSmallInt>("grantor");
        
        public static readonly Column<SqlInt> Id = new Column<SqlInt>("id");
        
        public static readonly Column<SqlTinyInt> Protecttype = new Column<SqlTinyInt>("protecttype");
        
        public static readonly Column<SqlSmallInt> Uid = new Column<SqlSmallInt>("uid");
    }
}
