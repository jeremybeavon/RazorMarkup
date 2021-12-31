using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextIndexes
    {
        public static readonly ViewName ViewName = new("sys.fulltext_indexes");

        public static readonly Column<SqlChar> ChangeTrackingState = new("change_tracking_state");

        public static readonly Column<SqlNVarchar> ChangeTrackingStateDesc = new("change_tracking_state_desc");

        public static readonly Column<SqlDateTime> CrawlEndDate = new("crawl_end_date");

        public static readonly Column<SqlDateTime> CrawlStartDate = new("crawl_start_date");

        public static readonly Column<SqlChar> CrawlType = new("crawl_type");

        public static readonly Column<SqlNVarchar> CrawlTypeDesc = new("crawl_type_desc");

        public static readonly Column<SqlInt> DataSpaceId = new("data_space_id");

        public static readonly Column<SqlInt> FulltextCatalogId = new("fulltext_catalog_id");

        public static readonly Column<SqlBit> HasCrawlCompleted = new("has_crawl_completed");

        public static readonly Column<SqlBinary> IncrementalTimestamp = new("incremental_timestamp");

        public static readonly Column<SqlBit> IsEnabled = new("is_enabled");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> PropertyListId = new("property_list_id");

        public static readonly Column<SqlInt> StoplistId = new("stoplist_id");

        public static readonly Column<SqlInt> UniqueIndexId = new("unique_index_id");
    }
}
