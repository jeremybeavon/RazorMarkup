using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsOutstandingBatches
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_fts_outstanding_batches");
        
        public static readonly Column<SqlInt> BatchId = new Column<SqlInt>("batch_id");
        
        public static readonly Column<SqlBinary> BatchTimestamp = new Column<SqlBinary>("batch_timestamp");
        
        public static readonly Column<SqlInt> CatalogId = new Column<SqlInt>("catalog_id");
        
        public static readonly Column<SqlVarbinary> CrawlMemoryAddress = new Column<SqlVarbinary>("crawl_memory_address");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlBigInt> DocFailed = new Column<SqlBigInt>("doc_failed");
        
        public static readonly Column<SqlInt> HrBatch = new Column<SqlInt>("hr_batch");
        
        public static readonly Column<SqlBit> IsRetryBatch = new Column<SqlBit>("is_retry_batch");
        
        public static readonly Column<SqlVarbinary> MemoryAddress = new Column<SqlVarbinary>("memory_address");
        
        public static readonly Column<SqlVarbinary> MemregionMemoryAddress = new Column<SqlVarbinary>("memregion_memory_address");
        
        public static readonly Column<SqlInt> RetryHints = new Column<SqlInt>("retry_hints");
        
        public static readonly Column<SqlNVarchar> RetryHintsDescription = new Column<SqlNVarchar>("retry_hints_description");
        
        public static readonly Column<SqlInt> TableId = new Column<SqlInt>("table_id");
    }
}
