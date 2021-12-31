using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextIndexFragments
    {
        public static readonly ViewName ViewName = new("sys.fulltext_index_fragments");

        public static readonly Column<SqlBigInt> DataSize = new("data_size");

        public static readonly Column<SqlInt> FragmentId = new("fragment_id");

        public static readonly Column<SqlInt> FragmentObjectId = new("fragment_object_id");

        public static readonly Column<SqlBigInt> RowCount = new("row_count");

        public static readonly Column<SqlInt> Status = new("status");

        public static readonly Column<SqlInt> TableId = new("table_id");

        public static readonly Column<SqlBinary> Timestamp = new("timestamp");
    }
}
