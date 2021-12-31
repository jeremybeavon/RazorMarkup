using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmDbFtsIndexPhysicalStats
    {
        public static readonly ViewName ViewName = new("sys.dm_db_fts_index_physical_stats");

        public static readonly Column<SqlBigInt> FulltextIndexPageCount = new("fulltext_index_page_count");

        public static readonly Column<SqlBigInt> KeyphraseIndexPageCount = new("keyphrase_index_page_count");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlBigInt> SimilarityIndexPageCount = new("similarity_index_page_count");
    }
}
