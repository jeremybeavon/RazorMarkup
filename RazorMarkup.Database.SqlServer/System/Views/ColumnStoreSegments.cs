using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ColumnStoreSegments
    {
        public static readonly ViewName ViewName = new ViewName("sys.column_store_segments");
        
        public static readonly Column<SqlBigInt> BaseId = new Column<SqlBigInt>("base_id");
        
        public static readonly Column<SqlInt> ColumnId = new Column<SqlInt>("column_id");
        
        public static readonly Column<SqlInt> EncodingType = new Column<SqlInt>("encoding_type");
        
        public static readonly Column<SqlBit> HasNulls = new Column<SqlBit>("has_nulls");
        
        public static readonly Column<SqlBigInt> HobtId = new Column<SqlBigInt>("hobt_id");
        
        public static readonly Column<SqlFloat> Magnitude = new Column<SqlFloat>("magnitude");
        
        public static readonly Column<SqlBigInt> MaxDataId = new Column<SqlBigInt>("max_data_id");
        
        public static readonly Column<SqlBigInt> MinDataId = new Column<SqlBigInt>("min_data_id");
        
        public static readonly Column<SqlBigInt> NullValue = new Column<SqlBigInt>("null_value");
        
        public static readonly Column<SqlBigInt> OnDiskSize = new Column<SqlBigInt>("on_disk_size");
        
        public static readonly Column<SqlBigInt> PartitionId = new Column<SqlBigInt>("partition_id");
        
        public static readonly Column<SqlInt> PrimaryDictionaryId = new Column<SqlInt>("primary_dictionary_id");
        
        public static readonly Column<SqlInt> RowCount = new Column<SqlInt>("row_count");
        
        public static readonly Column<SqlInt> SecondaryDictionaryId = new Column<SqlInt>("secondary_dictionary_id");
        
        public static readonly Column<SqlInt> SegmentId = new Column<SqlInt>("segment_id");
        
        public static readonly Column<SqlInt> Version = new Column<SqlInt>("version");
    }
}
