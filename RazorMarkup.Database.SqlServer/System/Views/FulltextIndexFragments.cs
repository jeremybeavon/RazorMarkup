using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextIndexFragments
    {
        public static readonly ViewName ViewName = new ViewName("sys.fulltext_index_fragments");
        
        public static readonly Column<SqlBigInt> DataSize = new Column<SqlBigInt>("data_size");
        
        public static readonly Column<SqlInt> FragmentId = new Column<SqlInt>("fragment_id");
        
        public static readonly Column<SqlInt> FragmentObjectId = new Column<SqlInt>("fragment_object_id");
        
        public static readonly Column<SqlBigInt> RowCount = new Column<SqlBigInt>("row_count");
        
        public static readonly Column<SqlInt> Status = new Column<SqlInt>("status");
        
        public static readonly Column<SqlInt> TableId = new Column<SqlInt>("table_id");
        
        public static readonly Column<SqlBinary> Timestamp = new Column<SqlBinary>("timestamp");
    }
}
