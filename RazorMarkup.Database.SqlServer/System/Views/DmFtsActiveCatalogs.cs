using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsActiveCatalogs
    {
        public static readonly ViewName ViewName = new("sys.dm_fts_active_catalogs");

        public static readonly Column<SqlInt> ActiveFtsIndexCount = new("active_fts_index_count");

        public static readonly Column<SqlInt> AutoPopulationCount = new("auto_population_count");

        public static readonly Column<SqlInt> CatalogId = new("catalog_id");

        public static readonly Column<SqlInt> DatabaseId = new("database_id");

        public static readonly Column<SqlInt> FullIncrementalPopulationCount = new("full_incremental_population_count");

        public static readonly Column<SqlBit> IsImporting = new("is_importing");

        public static readonly Column<SqlBit> IsPaused = new("is_paused");

        public static readonly Column<SqlInt> ManualPopulationCount = new("manual_population_count");

        public static readonly Column<SqlVarbinary> MemoryAddress = new("memory_address");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlInt> PreviousStatus = new("previous_status");

        public static readonly Column<SqlNVarchar> PreviousStatusDescription = new("previous_status_description");

        public static readonly Column<SqlInt> RowCountInThousands = new("row_count_in_thousands");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlNVarchar> StatusDescription = new("status_description");

        public static readonly Column<SqlInt> WorkerCount = new("worker_count");
    }
}
