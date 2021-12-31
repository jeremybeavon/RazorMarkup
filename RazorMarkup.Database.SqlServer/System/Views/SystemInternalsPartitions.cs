using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SystemInternalsPartitions
    {
        public static readonly ViewName ViewName = new("sys.system_internals_partitions");

        public static readonly Column<SqlBit> AllowPageLocks = new("allow_page_locks");

        public static readonly Column<SqlBit> AllowRowLocks = new("allow_row_locks");

        public static readonly Column<SqlBit> AllowsNullableKeys = new("allows_nullable_keys");

        public static readonly Column<SqlTinyInt> DroppedLobColumnState = new("dropped_lob_column_state");

        public static readonly Column<SqlSmallInt> FilestreamFilegroupId = new("filestream_filegroup_id");

        public static readonly Column<SqlUniqueIdentifier> FilestreamGuid = new("filestream_guid");

        public static readonly Column<SqlInt> IndexId = new("index_id");

        public static readonly Column<SqlBit> IsDataRowFormat = new("is_data_row_format");

        public static readonly Column<SqlBit> IsLoggedForReplication = new("is_logged_for_replication");

        public static readonly Column<SqlBit> IsNotVersioned = new("is_not_versioned");

        public static readonly Column<SqlBit> IsOrphaned = new("is_orphaned");

        public static readonly Column<SqlBit> IsReplicated = new("is_replicated");

        public static readonly Column<SqlBit> IsSereplicated = new("is_sereplicated");

        public static readonly Column<SqlBit> IsUnique = new("is_unique");

        public static readonly Column<SqlSmallInt> MaxInternalLength = new("max_internal_length");

        public static readonly Column<SqlInt> MaxLeafLength = new("max_leaf_length");

        public static readonly Column<SqlSmallInt> MaxNullBitUsed = new("max_null_bit_used");

        public static readonly Column<SqlSmallInt> MinInternalLength = new("min_internal_length");

        public static readonly Column<SqlSmallInt> MinLeafLength = new("min_leaf_length");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlBigInt> PartitionId = new("partition_id");

        public static readonly Column<SqlInt> PartitionNumber = new("partition_number");

        public static readonly Column<SqlBigInt> Rows = new("rows");
    }
}
