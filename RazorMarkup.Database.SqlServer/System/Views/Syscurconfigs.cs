using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SysCurConfigs
    {
        public static readonly ViewName ViewName = new("sys.syscurconfigs");

        public static readonly Column<SqlNVarchar> Comment = new("comment");

        public static readonly Column<SqlSmallInt> Config = new("config");

        public static readonly Column<SqlSmallInt> Status = new("status");

        public static readonly Column<SqlInt> Value = new("value");
    }
}
