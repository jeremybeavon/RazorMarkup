using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbPartitionStats
    {
        public static readonly ViewName ViewName = new("sys.dm_db_partition_stats");

        public static readonly Column<SqlBigInt> InRowDataPageCount = new("in_row_data_page_count");

        public static readonly Column<SqlBigInt> InRowReservedPageCount = new("in_row_reserved_page_count");

        public static readonly Column<SqlBigInt> InRowUsedPageCount = new("in_row_used_page_count");

        public static readonly Column<SqlInt> IndexId = new("index_id");

        public static readonly Column<SqlBigInt> LobReservedPageCount = new("lob_reserved_page_count");

        public static readonly Column<SqlBigInt> LobUsedPageCount = new("lob_used_page_count");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlBigInt> PartitionId = new("partition_id");

        public static readonly Column<SqlInt> PartitionNumber = new("partition_number");

        public static readonly Column<SqlBigInt> ReservedPageCount = new("reserved_page_count");

        public static readonly Column<SqlBigInt> RowCount = new("row_count");

        public static readonly Column<SqlBigInt> RowOverflowReservedPageCount = new("row_overflow_reserved_page_count");

        public static readonly Column<SqlBigInt> RowOverflowUsedPageCount = new("row_overflow_used_page_count");

        public static readonly Column<SqlBigInt> UsedPageCount = new("used_page_count");
    }
}
