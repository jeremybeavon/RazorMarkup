using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmTranVersionStore
    {
        public static readonly ViewName ViewName = new("sys.dm_tran_version_store");

        public static readonly Column<SqlSmallInt> DatabaseId = new("database_id");

        public static readonly Column<SqlSmallInt> MinLengthInBytes = new("min_length_in_bytes");

        public static readonly Column<SqlVarbinary> RecordImageFirstPart = new("record_image_first_part");

        public static readonly Column<SqlVarbinary> RecordImageSecondPart = new("record_image_second_part");

        public static readonly Column<SqlSmallInt> RecordLengthFirstPartInBytes = new("record_length_first_part_in_bytes");

        public static readonly Column<SqlSmallInt> RecordLengthSecondPartInBytes = new("record_length_second_part_in_bytes");

        public static readonly Column<SqlBigInt> RowsetId = new("rowset_id");

        public static readonly Column<SqlTinyInt> Status = new("status");

        public static readonly Column<SqlBigInt> TransactionSequenceNum = new("transaction_sequence_num");

        public static readonly Column<SqlBigInt> VersionSequenceNum = new("version_sequence_num");
    }
}
