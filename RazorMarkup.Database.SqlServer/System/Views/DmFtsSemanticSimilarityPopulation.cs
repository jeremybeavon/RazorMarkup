using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsSemanticSimilarityPopulation
    {
        public static readonly ViewName ViewName = new("sys.dm_fts_semantic_similarity_population");

        public static readonly Column<SqlInt> CatalogId = new("catalog_id");

        public static readonly Column<SqlInt> CompletionType = new("completion_type");

        public static readonly Column<SqlNVarchar> CompletionTypeDescription = new("completion_type_description");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlBigInt> DocumentCount = new("document_count");

        public static readonly Column<SqlBigInt> DocumentProcessedCount = new("document_processed_count");

        public static readonly Column<SqlBinary> IncrementalTimestamp = new("incremental_timestamp");

        public static readonly Column<SqlDateTime> StartTime = new("start_time");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlNVarchar> StatusDescription = new("status_description");

        public static readonly Column<SqlInt> TableId = new("table_id");

        public static readonly Column<SqlInt> WorkerCount = new("worker_count");
    }
}
