using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextIndexes
    {
        public static readonly ViewName ViewName = new ViewName("sys.fulltext_indexes");
        
        public static readonly Column<SqlChar> ChangeTrackingState = new Column<SqlChar>("change_tracking_state");
        
        public static readonly Column<SqlNVarchar> ChangeTrackingStateDesc = new Column<SqlNVarchar>("change_tracking_state_desc");
        
        public static readonly Column<SqlDateTime> CrawlEndDate = new Column<SqlDateTime>("crawl_end_date");
        
        public static readonly Column<SqlDateTime> CrawlStartDate = new Column<SqlDateTime>("crawl_start_date");
        
        public static readonly Column<SqlChar> CrawlType = new Column<SqlChar>("crawl_type");
        
        public static readonly Column<SqlNVarchar> CrawlTypeDesc = new Column<SqlNVarchar>("crawl_type_desc");
        
        public static readonly Column<SqlInt> DataSpaceId = new Column<SqlInt>("data_space_id");
        
        public static readonly Column<SqlInt> FulltextCatalogId = new Column<SqlInt>("fulltext_catalog_id");
        
        public static readonly Column<SqlBit> HasCrawlCompleted = new Column<SqlBit>("has_crawl_completed");
        
        public static readonly Column<SqlBinary> IncrementalTimestamp = new Column<SqlBinary>("incremental_timestamp");
        
        public static readonly Column<SqlBit> IsEnabled = new Column<SqlBit>("is_enabled");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> PropertyListId = new Column<SqlInt>("property_list_id");
        
        public static readonly Column<SqlInt> StoplistId = new Column<SqlInt>("stoplist_id");
        
        public static readonly Column<SqlInt> UniqueIndexId = new Column<SqlInt>("unique_index_id");
    }
}
