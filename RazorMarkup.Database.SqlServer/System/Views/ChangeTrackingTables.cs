using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class ChangeTrackingTables
    {
        public static readonly ViewName ViewName = new ViewName("sys.change_tracking_tables");

        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");

        public static readonly Column<SqlBit> IsTrackColumnsUpdatedOn = new Column<SqlBit>("is_track_columns_updated_on");

        public static readonly Column<SqlBigInt> BeginVersion = new Column<SqlBigInt>("begin_version");

        public static readonly Column<SqlBigInt> CleanupVersion = new Column<SqlBigInt>("cleanup_version");

        public static readonly Column<SqlBigInt> MinValidVersion = new Column<SqlBigInt>("min_valid_version");
    }
}
