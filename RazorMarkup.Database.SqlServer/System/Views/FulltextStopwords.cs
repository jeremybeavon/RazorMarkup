using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextStopwords
    {
        public static readonly ViewName ViewName = new("sys.fulltext_stopwords");

        public static readonly Column<SqlNVarchar> Language = new("language");

        public static readonly Column<SqlInt> LanguageId = new("language_id");

        public static readonly Column<SqlInt> StoplistId = new("stoplist_id");

        public static readonly Column<SqlNVarchar> Stopword = new("stopword");
    }
}
