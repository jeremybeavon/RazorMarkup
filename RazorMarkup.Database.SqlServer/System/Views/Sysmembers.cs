using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Sysmembers
    {
        public static readonly ViewName ViewName = new ViewName("sys.sysmembers");
        
        public static readonly Column<SqlSmallInt> Groupuid = new Column<SqlSmallInt>("groupuid");
        
        public static readonly Column<SqlSmallInt> Memberuid = new Column<SqlSmallInt>("memberuid");
    }
}
