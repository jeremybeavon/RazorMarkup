using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranVersionStore
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_tran_version_store");
        
        public static readonly Column<SqlSmallInt> DatabaseId = new Column<SqlSmallInt>("database_id");
        
        public static readonly Column<SqlSmallInt> MinLengthInBytes = new Column<SqlSmallInt>("min_length_in_bytes");
        
        public static readonly Column<SqlVarbinary> RecordImageFirstPart = new Column<SqlVarbinary>("record_image_first_part");
        
        public static readonly Column<SqlVarbinary> RecordImageSecondPart = new Column<SqlVarbinary>("record_image_second_part");
        
        public static readonly Column<SqlSmallInt> RecordLengthFirstPartInBytes = new Column<SqlSmallInt>("record_length_first_part_in_bytes");
        
        public static readonly Column<SqlSmallInt> RecordLengthSecondPartInBytes = new Column<SqlSmallInt>("record_length_second_part_in_bytes");
        
        public static readonly Column<SqlBigInt> RowsetId = new Column<SqlBigInt>("rowset_id");
        
        public static readonly Column<SqlTinyInt> Status = new Column<SqlTinyInt>("status");
        
        public static readonly Column<SqlBigInt> TransactionSequenceNum = new Column<SqlBigInt>("transaction_sequence_num");
        
        public static readonly Column<SqlBigInt> VersionSequenceNum = new Column<SqlBigInt>("version_sequence_num");
    }
}
