using RazorMarkup.Database.SqlServer.System.Views.Values;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class ChangeTrackingDatabases
    {
        public static readonly ViewName ViewName = new("sys.change_tracking_databases");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlBit> IsAutoCleanupOn = new("is_auto_cleanup_on");

        public static readonly Column<SqlInt> RetentionPeriod = new("retention_period");

        public static readonly Column<SqlTinyInt, ChangeTrackingDatabasesRetentionPeriodUnits> RetentionPeriodUnits =
            new("retention_period_units");

        public static readonly Column<SqlNVarchar, ChangeTrackingDatabasesRetentionPeriodUnitsDescriptions> RetentionPeriodUnitsDescription =
             new("retention_period_units_desc");
    }
}
