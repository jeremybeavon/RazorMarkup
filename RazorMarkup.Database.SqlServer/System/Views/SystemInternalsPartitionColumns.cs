using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SystemInternalsPartitionColumns
    {
        public static readonly ViewName ViewName = new ViewName("sys.system_internals_partition_columns");
        
        public static readonly Column<SqlSysname> CollationName = new Column<SqlSysname>("collation_name");
        
        public static readonly Column<SqlVariant> DefaultValue = new Column<SqlVariant>("default_value");
        
        public static readonly Column<SqlBit> HasDefault = new Column<SqlBit>("has_default");
        
        public static readonly Column<SqlTinyInt> InternalBitPosition = new Column<SqlTinyInt>("internal_bit_position");
        
        public static readonly Column<SqlSmallInt> InternalNullBit = new Column<SqlSmallInt>("internal_null_bit");
        
        public static readonly Column<SqlSmallInt> InternalOffset = new Column<SqlSmallInt>("internal_offset");
        
        public static readonly Column<SqlBit> IsAntiMatter = new Column<SqlBit>("is_anti_matter");
        
        public static readonly Column<SqlBit> IsDescendingKey = new Column<SqlBit>("is_descending_key");
        
        public static readonly Column<SqlBit> IsDropped = new Column<SqlBit>("is_dropped");
        
        public static readonly Column<SqlBit> IsFilestream = new Column<SqlBit>("is_filestream");
        
        public static readonly Column<SqlBit> IsLoggedForReplication = new Column<SqlBit>("is_logged_for_replication");
        
        public static readonly Column<SqlBit> IsNullable = new Column<SqlBit>("is_nullable");
        
        public static readonly Column<SqlBit> IsReplicated = new Column<SqlBit>("is_replicated");
        
        public static readonly Column<SqlBit> IsSparse = new Column<SqlBit>("is_sparse");
        
        public static readonly Column<SqlBit> IsUniqueifier = new Column<SqlBit>("is_uniqueifier");
        
        public static readonly Column<SqlSmallInt> KeyOrdinal = new Column<SqlSmallInt>("key_ordinal");
        
        public static readonly Column<SqlTinyInt> LeafBitPosition = new Column<SqlTinyInt>("leaf_bit_position");
        
        public static readonly Column<SqlSmallInt> LeafNullBit = new Column<SqlSmallInt>("leaf_null_bit");
        
        public static readonly Column<SqlSmallInt> LeafOffset = new Column<SqlSmallInt>("leaf_offset");
        
        public static readonly Column<SqlSmallInt> MaxInrowLength = new Column<SqlSmallInt>("max_inrow_length");
        
        public static readonly Column<SqlSmallInt> MaxLength = new Column<SqlSmallInt>("max_length");
        
        public static readonly Column<SqlBigInt> ModifiedCount = new Column<SqlBigInt>("modified_count");
        
        public static readonly Column<SqlUniqueIdentifier> PartitionColumnGuid = new Column<SqlUniqueIdentifier>("partition_column_guid");
        
        public static readonly Column<SqlInt> PartitionColumnId = new Column<SqlInt>("partition_column_id");
        
        public static readonly Column<SqlBigInt> PartitionId = new Column<SqlBigInt>("partition_id");
        
        public static readonly Column<SqlTinyInt> Precision = new Column<SqlTinyInt>("precision");
        
        public static readonly Column<SqlTinyInt> Scale = new Column<SqlTinyInt>("scale");
        
        public static readonly Column<SqlTinyInt> SystemTypeId = new Column<SqlTinyInt>("system_type_id");
    }
}
