using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysMembers
    {
        public static readonly ViewName ViewName = new("sys.sysmembers");

        public static readonly Column<SqlSmallInt> Groupuid = new("groupuid");

        public static readonly Column<SqlSmallInt> Memberuid = new("memberuid");
    }
}
