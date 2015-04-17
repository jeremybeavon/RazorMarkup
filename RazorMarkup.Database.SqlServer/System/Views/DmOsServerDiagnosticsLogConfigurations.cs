using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsServerDiagnosticsLogConfigurations
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_server_diagnostics_log_configurations");
        
        public static readonly Column<SqlInt> IsEnabled = new Column<SqlInt>("is_enabled");
        
        public static readonly Column<SqlInt> MaxFiles = new Column<SqlInt>("max_files");
        
        public static readonly Column<SqlInt> MaxSize = new Column<SqlInt>("max_size");
        
        public static readonly Column<SqlNVarchar> Path = new Column<SqlNVarchar>("path");
    }
}
