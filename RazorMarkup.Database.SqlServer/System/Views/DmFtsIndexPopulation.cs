using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsIndexPopulation
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_fts_index_population");
        
        public static readonly Column<SqlInt> CatalogId = new Column<SqlInt>("catalog_id");
        
        public static readonly Column<SqlInt> CompletedRangeCount = new Column<SqlInt>("completed_range_count");
        
        public static readonly Column<SqlInt> CompletionType = new Column<SqlInt>("completion_type");
        
        public static readonly Column<SqlNVarchar> CompletionTypeDescription = new Column<SqlNVarchar>("completion_type_description");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlBinary> IncrementalTimestamp = new Column<SqlBinary>("incremental_timestamp");
        
        public static readonly Column<SqlBit> IsClusteredIndexScan = new Column<SqlBit>("is_clustered_index_scan");
        
        public static readonly Column<SqlVarbinary> MemoryAddress = new Column<SqlVarbinary>("memory_address");
        
        public static readonly Column<SqlInt> OutstandingBatchCount = new Column<SqlInt>("outstanding_batch_count");
        
        public static readonly Column<SqlInt> PopulationType = new Column<SqlInt>("population_type");
        
        public static readonly Column<SqlNVarchar> PopulationTypeDescription = new Column<SqlNVarchar>("population_type_description");
        
        public static readonly Column<SqlInt> QueuedPopulationType = new Column<SqlInt>("queued_population_type");
        
        public static readonly Column<SqlNVarchar> QueuedPopulationTypeDescription = new Column<SqlNVarchar>("queued_population_type_description");
        
        public static readonly Column<SqlInt> RangeCount = new Column<SqlInt>("range_count");
        
        public static readonly Column<SqlDateTime> StartTime = new Column<SqlDateTime>("start_time");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlNVarchar> StatusDescription = new Column<SqlNVarchar>("status_description");
        
        public static readonly Column<SqlInt> TableId = new Column<SqlInt>("table_id");
        
        public static readonly Column<SqlInt> WorkerCount = new Column<SqlInt>("worker_count");
    }
}
