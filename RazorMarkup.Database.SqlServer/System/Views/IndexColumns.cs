using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class IndexColumns
    {
        public static readonly ViewName ViewName = new("sys.index_columns");

        public static readonly Column<SqlInt> ColumnId = new("column_id");

        public static readonly Column<SqlInt> IndexColumnId = new("index_column_id");

        public static readonly Column<SqlInt> IndexId = new("index_id");

        public static readonly Column<SqlBit> IsDescendingKey = new("is_descending_key");

        public static readonly Column<SqlBit> IsIncludedColumn = new("is_included_column");

        public static readonly Column<SqlTinyInt> KeyOrdinal = new("key_ordinal");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlTinyInt> PartitionOrdinal = new("partition_ordinal");
    }
}
