using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmOsClusterProperties
    {
        public static readonly ViewName ViewName = new("sys.dm_os_cluster_properties");

        public static readonly Column<SqlBigInt> Failureconditionlevel = new("FailureConditionLevel");

        public static readonly Column<SqlBigInt> Healthchecktimeout = new("HealthCheckTimeout");

        public static readonly Column<SqlBigInt> Sqldumperdumpflags = new("SqlDumperDumpFlags");

        public static readonly Column<SqlNVarchar> Sqldumperdumppath = new("SqlDumperDumpPath");

        public static readonly Column<SqlBigInt> Sqldumperdumptimeout = new("SqlDumperDumpTimeOut");

        public static readonly Column<SqlBigInt> Verboselogging = new("VerboseLogging");
    }
}
