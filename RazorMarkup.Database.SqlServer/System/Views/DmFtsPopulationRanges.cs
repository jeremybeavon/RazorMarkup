using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsPopulationRanges
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_fts_population_ranges");
        
        public static readonly Column<SqlInt> ErrorCount = new Column<SqlInt>("error_count");
        
        public static readonly Column<SqlBit> IsRetry = new Column<SqlBit>("is_retry");
        
        public static readonly Column<SqlVarbinary> MemoryAddress = new Column<SqlVarbinary>("memory_address");
        
        public static readonly Column<SqlVarbinary> ParentMemoryAddress = new Column<SqlVarbinary>("parent_memory_address");
        
        public static readonly Column<SqlInt> ProcessedRowCount = new Column<SqlInt>("processed_row_count");
        
        public static readonly Column<SqlSmallInt> SessionId = new Column<SqlSmallInt>("session_id");
    }
}
