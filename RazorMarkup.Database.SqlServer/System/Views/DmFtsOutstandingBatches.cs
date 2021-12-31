using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsOutstandingBatches
    {
        public static readonly ViewName ViewName = new("sys.dm_fts_outstanding_batches");

        public static readonly Column<SqlInt> BatchId = new("batch_id");

        public static readonly Column<SqlBinary> BatchTimestamp = new("batch_timestamp");

        public static readonly Column<SqlInt> CatalogId = new("catalog_id");

        public static readonly Column<SqlVarbinary> CrawlMemoryAddress = new("crawl_memory_address");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlBigInt> DocFailed = new("doc_failed");

        public static readonly Column<SqlInt> HrBatch = new("hr_batch");

        public static readonly Column<SqlBit> IsRetryBatch = new("is_retry_batch");

        public static readonly Column<SqlVarbinary> MemoryAddress = new("memory_address");

        public static readonly Column<SqlVarbinary> MemregionMemoryAddress = new("memregion_memory_address");

        public static readonly Column<SqlInt> RetryHints = new("retry_hints");

        public static readonly Column<SqlNVarchar> RetryHintsDescription = new("retry_hints_description");

        public static readonly Column<SqlInt> TableId = new("table_id");
    }
}
