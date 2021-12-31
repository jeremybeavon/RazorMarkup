using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public abstract class ChangeTrackingTables
    {
        public static readonly ViewName ViewName = new("sys.change_tracking_tables");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlBit> IsTrackColumnsUpdatedOn = new("is_track_columns_updated_on");

        public static readonly Column<SqlBigInt> BeginVersion = new("begin_version");

        public static readonly Column<SqlBigInt> CleanupVersion = new("cleanup_version");

        public static readonly Column<SqlBigInt> MinValidVersion = new("min_valid_version");
    }
}
