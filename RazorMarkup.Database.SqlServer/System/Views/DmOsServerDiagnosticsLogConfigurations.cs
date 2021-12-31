using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsServerDiagnosticsLogConfigurations
    {
        public static readonly ViewName ViewName = new("sys.dm_os_server_diagnostics_log_configurations");

        public static readonly Column<SqlInt> IsEnabled = new("is_enabled");

        public static readonly Column<SqlInt> MaxFiles = new("max_files");

        public static readonly Column<SqlInt> MaxSize = new("max_size");

        public static readonly Column<SqlNVarchar> Path = new("path");
    }
}
