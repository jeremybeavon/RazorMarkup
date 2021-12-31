using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsIndexPopulation
    {
        public static readonly ViewName ViewName = new("sys.dm_fts_index_population");

        public static readonly Column<SqlInt> CatalogId = new("catalog_id");

        public static readonly Column<SqlInt> CompletedRangeCount = new("completed_range_count");

        public static readonly Column<SqlInt> CompletionType = new("completion_type");

        public static readonly Column<SqlNVarchar> CompletionTypeDescription = new("completion_type_description");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlBinary> IncrementalTimestamp = new("incremental_timestamp");

        public static readonly Column<SqlBit> IsClusteredIndexScan = new("is_clustered_index_scan");

        public static readonly Column<SqlVarbinary> MemoryAddress = new("memory_address");

        public static readonly Column<SqlInt> OutstandingBatchCount = new("outstanding_batch_count");

        public static readonly Column<SqlInt> PopulationType = new("population_type");

        public static readonly Column<SqlNVarchar> PopulationTypeDescription = new("population_type_description");

        public static readonly Column<SqlInt> QueuedPopulationType = new("queued_population_type");

        public static readonly Column<SqlNVarchar> QueuedPopulationTypeDescription = new("queued_population_type_description");

        public static readonly Column<SqlInt> RangeCount = new("range_count");

        public static readonly Column<SqlDateTime> StartTime = new("start_time");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlNVarchar> StatusDescription = new("status_description");

        public static readonly Column<SqlInt> TableId = new("table_id");

        public static readonly Column<SqlInt> WorkerCount = new("worker_count");
    }
}
