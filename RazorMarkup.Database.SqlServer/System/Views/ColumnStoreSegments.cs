using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ColumnStoreSegments
    {
        public static readonly ViewName ViewName = new("sys.column_store_segments");

        public static readonly Column<SqlBigInt> BaseId = new("base_id");

        public static readonly Column<SqlInt> ColumnId = new("column_id");

        public static readonly Column<SqlInt> EncodingType = new("encoding_type");

        public static readonly Column<SqlBit> HasNulls = new("has_nulls");

        public static readonly Column<SqlBigInt> HobtId = new("hobt_id");

        public static readonly Column<SqlFloat> Magnitude = new("magnitude");

        public static readonly Column<SqlBigInt> MaxDataId = new("max_data_id");

        public static readonly Column<SqlBigInt> MinDataId = new("min_data_id");

        public static readonly Column<SqlBigInt> NullValue = new("null_value");

        public static readonly Column<SqlBigInt> OnDiskSize = new("on_disk_size");

        public static readonly Column<SqlBigInt> PartitionId = new("partition_id");

        public static readonly Column<SqlInt> PrimaryDictionaryId = new("primary_dictionary_id");

        public static readonly Column<SqlInt> RowCount = new("row_count");

        public static readonly Column<SqlInt> SecondaryDictionaryId = new("secondary_dictionary_id");

        public static readonly Column<SqlInt> SegmentId = new("segment_id");

        public static readonly Column<SqlInt> Version = new("version");
    }
}
