using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsWindowsInfo
    {
        public static readonly ViewName ViewName = new("sys.dm_os_windows_info");

        public static readonly Column<SqlInt> OsLanguageVersion = new("os_language_version");

        public static readonly Column<SqlNVarchar> WindowsRelease = new("windows_release");

        public static readonly Column<SqlNVarchar> WindowsServicePackLevel = new("windows_service_pack_level");

        public static readonly Column<SqlInt> WindowsSku = new("windows_sku");
    }
}
