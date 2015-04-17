using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsClusterProperties
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_os_cluster_properties");
        
        public static readonly Column<SqlBigInt> Failureconditionlevel = new Column<SqlBigInt>("FailureConditionLevel");
        
        public static readonly Column<SqlBigInt> Healthchecktimeout = new Column<SqlBigInt>("HealthCheckTimeout");
        
        public static readonly Column<SqlBigInt> Sqldumperdumpflags = new Column<SqlBigInt>("SqlDumperDumpFlags");
        
        public static readonly Column<SqlNVarchar> Sqldumperdumppath = new Column<SqlNVarchar>("SqlDumperDumpPath");
        
        public static readonly Column<SqlBigInt> Sqldumperdumptimeout = new Column<SqlBigInt>("SqlDumperDumpTimeOut");
        
        public static readonly Column<SqlBigInt> Verboselogging = new Column<SqlBigInt>("VerboseLogging");
    }
}
