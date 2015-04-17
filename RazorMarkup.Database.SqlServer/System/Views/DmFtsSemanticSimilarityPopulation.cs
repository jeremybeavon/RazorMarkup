using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsSemanticSimilarityPopulation
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_fts_semantic_similarity_population");
        
        public static readonly Column<SqlInt> CatalogId = new Column<SqlInt>("catalog_id");
        
        public static readonly Column<SqlInt> CompletionType = new Column<SqlInt>("completion_type");
        
        public static readonly Column<SqlNVarchar> CompletionTypeDescription = new Column<SqlNVarchar>("completion_type_description");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlBigInt> DocumentCount = new Column<SqlBigInt>("document_count");
        
        public static readonly Column<SqlBigInt> DocumentProcessedCount = new Column<SqlBigInt>("document_processed_count");
        
        public static readonly Column<SqlBinary> IncrementalTimestamp = new Column<SqlBinary>("incremental_timestamp");
        
        public static readonly Column<SqlDateTime> StartTime = new Column<SqlDateTime>("start_time");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlNVarchar> StatusDescription = new Column<SqlNVarchar>("status_description");
        
        public static readonly Column<SqlInt> TableId = new Column<SqlInt>("table_id");
        
        public static readonly Column<SqlInt> WorkerCount = new Column<SqlInt>("worker_count");
    }
}
