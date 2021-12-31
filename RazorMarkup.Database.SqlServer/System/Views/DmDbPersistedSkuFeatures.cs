using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbPersistedSkuFeatures
    {
        public static readonly ViewName ViewName = new("sys.dm_db_persisted_sku_features");

        public static readonly Column<SqlInt> FeatureId = new("feature_id");

        public static readonly Column<SqlNVarchar> FeatureName = new("feature_name");
    }
}
