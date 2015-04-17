using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsActiveCatalogs
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_fts_active_catalogs");
        
        public static readonly Column<SqlInt> ActiveFtsIndexCount = new Column<SqlInt>("active_fts_index_count");
        
        public static readonly Column<SqlInt> AutoPopulationCount = new Column<SqlInt>("auto_population_count");
        
        public static readonly Column<SqlInt> CatalogId = new Column<SqlInt>("catalog_id");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlInt> FullIncrementalPopulationCount = new Column<SqlInt>("full_incremental_population_count");
        
        public static readonly Column<SqlBit> IsImporting = new Column<SqlBit>("is_importing");
        
        public static readonly Column<SqlBit> IsPaused = new Column<SqlBit>("is_paused");
        
        public static readonly Column<SqlInt> ManualPopulationCount = new Column<SqlInt>("manual_population_count");
        
        public static readonly Column<SqlVarbinary> MemoryAddress = new Column<SqlVarbinary>("memory_address");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlInt> PreviousStatus = new Column<SqlInt>("previous_status");
        
        public static readonly Column<SqlNVarchar> PreviousStatusDescription = new Column<SqlNVarchar>("previous_status_description");
        
        public static readonly Column<SqlInt> RowCountInThousands = new Column<SqlInt>("row_count_in_thousands");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlNVarchar> StatusDescription = new Column<SqlNVarchar>("status_description");
        
        public static readonly Column<SqlInt> WorkerCount = new Column<SqlInt>("worker_count");
    }
}
