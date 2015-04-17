using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextIndexCatalogUsages
    {
        public static readonly ViewName ViewName = new ViewName("sys.fulltext_index_catalog_usages");
        
        public static readonly Column<SqlInt> FulltextCatalogId = new Column<SqlInt>("fulltext_catalog_id");
        
        public static readonly Column<SqlInt> IndexId = new Column<SqlInt>("index_id");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
    }
}
