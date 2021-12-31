using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextIndexCatalogUsages
    {
        public static readonly ViewName ViewName = new("sys.fulltext_index_catalog_usages");

        public static readonly Column<SqlInt> FulltextCatalogId = new("fulltext_catalog_id");

        public static readonly Column<SqlInt> IndexId = new("index_id");

        public static readonly Column<SqlInt> ObjectId = new("object_id");
    }
}
