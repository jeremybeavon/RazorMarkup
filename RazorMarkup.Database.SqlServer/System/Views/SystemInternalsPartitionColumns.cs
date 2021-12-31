using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class SystemInternalsPartitionColumns
    {
        public static readonly ViewName ViewName = new("sys.system_internals_partition_columns");

        public static readonly Column<SqlSysname> CollationName = new("collation_name");

        public static readonly Column<SqlVariant> DefaultValue = new("default_value");

        public static readonly Column<SqlBit> HasDefault = new("has_default");

        public static readonly Column<SqlTinyInt> InternalBitPosition = new("internal_bit_position");

        public static readonly Column<SqlSmallInt> InternalNullBit = new("internal_null_bit");

        public static readonly Column<SqlSmallInt> InternalOffset = new("internal_offset");

        public static readonly Column<SqlBit> IsAntiMatter = new("is_anti_matter");

        public static readonly Column<SqlBit> IsDescendingKey = new("is_descending_key");

        public static readonly Column<SqlBit> IsDropped = new("is_dropped");

        public static readonly Column<SqlBit> IsFilestream = new("is_filestream");

        public static readonly Column<SqlBit> IsLoggedForReplication = new("is_logged_for_replication");

        public static readonly Column<SqlBit> IsNullable = new("is_nullable");

        public static readonly Column<SqlBit> IsReplicated = new("is_replicated");

        public static readonly Column<SqlBit> IsSparse = new("is_sparse");

        public static readonly Column<SqlBit> IsUniqueifier = new("is_uniqueifier");

        public static readonly Column<SqlSmallInt> KeyOrdinal = new("key_ordinal");

        public static readonly Column<SqlTinyInt> LeafBitPosition = new("leaf_bit_position");

        public static readonly Column<SqlSmallInt> LeafNullBit = new("leaf_null_bit");

        public static readonly Column<SqlSmallInt> LeafOffset = new("leaf_offset");

        public static readonly Column<SqlSmallInt> MaxInrowLength = new("max_inrow_length");

        public static readonly Column<SqlSmallInt> MaxLength = new("max_length");

        public static readonly Column<SqlBigInt> ModifiedCount = new("modified_count");

        public static readonly Column<SqlUniqueIdentifier> PartitionColumnGuid = new("partition_column_guid");

        public static readonly Column<SqlInt> PartitionColumnId = new("partition_column_id");

        public static readonly Column<SqlBigInt> PartitionId = new("partition_id");

        public static readonly Column<SqlTinyInt> Precision = new("precision");

        public static readonly Column<SqlTinyInt> Scale = new("scale");

        public static readonly Column<SqlTinyInt> SystemTypeId = new("system_type_id");
    }
}
