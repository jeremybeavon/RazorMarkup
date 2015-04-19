using RazorMarkup.Database.SqlServer.System.Views.Values;
using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class ChangeTrackingDatabases
    {
        public static readonly ViewName ViewName = new ViewName("sys.change_tracking_databases");

        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");

        public static readonly Column<SqlBit> IsAutoCleanupOn = new Column<SqlBit>("is_auto_cleanup_on");

        public static readonly Column<SqlInt> RetentionPeriod = new Column<SqlInt>("retention_period");

        public static readonly Column<SqlTinyInt, ChangeTrackingDatabasesRetentionPeriodUnits> RetentionPeriodUnits =
            new Column<SqlTinyInt, ChangeTrackingDatabasesRetentionPeriodUnits>("retention_period_units");

        public static readonly Column<SqlNVarchar, ChangeTrackingDatabasesRetentionPeriodUnitsDescriptions> RetentionPeriodUnitsDescription =
             new Column<SqlNVarchar, ChangeTrackingDatabasesRetentionPeriodUnitsDescriptions>("retention_period_units_desc");
    }
}
