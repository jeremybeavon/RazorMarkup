using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class IndexColumns
    {
        public static readonly ViewName ViewName = new ViewName("sys.index_columns");
        
        public static readonly Column<SqlInt> ColumnId = new Column<SqlInt>("column_id");
        
        public static readonly Column<SqlInt> IndexColumnId = new Column<SqlInt>("index_column_id");
        
        public static readonly Column<SqlInt> IndexId = new Column<SqlInt>("index_id");
        
        public static readonly Column<SqlBit> IsDescendingKey = new Column<SqlBit>("is_descending_key");
        
        public static readonly Column<SqlBit> IsIncludedColumn = new Column<SqlBit>("is_included_column");
        
        public static readonly Column<SqlTinyInt> KeyOrdinal = new Column<SqlTinyInt>("key_ordinal");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlTinyInt> PartitionOrdinal = new Column<SqlTinyInt>("partition_ordinal");
    }
}
