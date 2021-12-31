using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmFtsPopulationRanges
    {
        public static readonly ViewName ViewName = new("sys.dm_fts_population_ranges");

        public static readonly Column<SqlInt> ErrorCount = new("error_count");

        public static readonly Column<SqlBit> IsRetry = new("is_retry");

        public static readonly Column<SqlVarbinary> MemoryAddress = new("memory_address");

        public static readonly Column<SqlVarbinary> ParentMemoryAddress = new("parent_memory_address");

        public static readonly Column<SqlInt> ProcessedRowCount = new("processed_row_count");

        public static readonly Column<SqlSmallInt> SessionId = new("session_id");
    }
}
