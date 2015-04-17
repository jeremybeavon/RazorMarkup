using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbPartitionStats
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_db_partition_stats");
        
        public static readonly Column<SqlBigInt> InRowDataPageCount = new Column<SqlBigInt>("in_row_data_page_count");
        
        public static readonly Column<SqlBigInt> InRowReservedPageCount = new Column<SqlBigInt>("in_row_reserved_page_count");
        
        public static readonly Column<SqlBigInt> InRowUsedPageCount = new Column<SqlBigInt>("in_row_used_page_count");
        
        public static readonly Column<SqlInt> IndexId = new Column<SqlInt>("index_id");
        
        public static readonly Column<SqlBigInt> LobReservedPageCount = new Column<SqlBigInt>("lob_reserved_page_count");
        
        public static readonly Column<SqlBigInt> LobUsedPageCount = new Column<SqlBigInt>("lob_used_page_count");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlBigInt> PartitionId = new Column<SqlBigInt>("partition_id");
        
        public static readonly Column<SqlInt> PartitionNumber = new Column<SqlInt>("partition_number");
        
        public static readonly Column<SqlBigInt> ReservedPageCount = new Column<SqlBigInt>("reserved_page_count");
        
        public static readonly Column<SqlBigInt> RowCount = new Column<SqlBigInt>("row_count");
        
        public static readonly Column<SqlBigInt> RowOverflowReservedPageCount = new Column<SqlBigInt>("row_overflow_reserved_page_count");
        
        public static readonly Column<SqlBigInt> RowOverflowUsedPageCount = new Column<SqlBigInt>("row_overflow_used_page_count");
        
        public static readonly Column<SqlBigInt> UsedPageCount = new Column<SqlBigInt>("used_page_count");
    }
}
