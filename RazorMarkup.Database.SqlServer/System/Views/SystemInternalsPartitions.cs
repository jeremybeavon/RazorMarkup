using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SystemInternalsPartitions
    {
        public static readonly ViewName ViewName = new ViewName("sys.system_internals_partitions");
        
        public static readonly Column<SqlBit> AllowPageLocks = new Column<SqlBit>("allow_page_locks");
        
        public static readonly Column<SqlBit> AllowRowLocks = new Column<SqlBit>("allow_row_locks");
        
        public static readonly Column<SqlBit> AllowsNullableKeys = new Column<SqlBit>("allows_nullable_keys");
        
        public static readonly Column<SqlTinyInt> DroppedLobColumnState = new Column<SqlTinyInt>("dropped_lob_column_state");
        
        public static readonly Column<SqlSmallInt> FilestreamFilegroupId = new Column<SqlSmallInt>("filestream_filegroup_id");
        
        public static readonly Column<SqlUniqueIdentifier> FilestreamGuid = new Column<SqlUniqueIdentifier>("filestream_guid");
        
        public static readonly Column<SqlInt> IndexId = new Column<SqlInt>("index_id");
        
        public static readonly Column<SqlBit> IsDataRowFormat = new Column<SqlBit>("is_data_row_format");
        
        public static readonly Column<SqlBit> IsLoggedForReplication = new Column<SqlBit>("is_logged_for_replication");
        
        public static readonly Column<SqlBit> IsNotVersioned = new Column<SqlBit>("is_not_versioned");
        
        public static readonly Column<SqlBit> IsOrphaned = new Column<SqlBit>("is_orphaned");
        
        public static readonly Column<SqlBit> IsReplicated = new Column<SqlBit>("is_replicated");
        
        public static readonly Column<SqlBit> IsSereplicated = new Column<SqlBit>("is_sereplicated");
        
        public static readonly Column<SqlBit> IsUnique = new Column<SqlBit>("is_unique");
        
        public static readonly Column<SqlSmallInt> MaxInternalLength = new Column<SqlSmallInt>("max_internal_length");
        
        public static readonly Column<SqlInt> MaxLeafLength = new Column<SqlInt>("max_leaf_length");
        
        public static readonly Column<SqlSmallInt> MaxNullBitUsed = new Column<SqlSmallInt>("max_null_bit_used");
        
        public static readonly Column<SqlSmallInt> MinInternalLength = new Column<SqlSmallInt>("min_internal_length");
        
        public static readonly Column<SqlSmallInt> MinLeafLength = new Column<SqlSmallInt>("min_leaf_length");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlBigInt> PartitionId = new Column<SqlBigInt>("partition_id");
        
        public static readonly Column<SqlInt> PartitionNumber = new Column<SqlInt>("partition_number");
        
        public static readonly Column<SqlBigInt> Rows = new Column<SqlBigInt>("rows");
    }
}
