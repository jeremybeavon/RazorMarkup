using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextStopwords
    {
        public static readonly ViewName ViewName = new ViewName("sys.fulltext_stopwords");
        
        public static readonly Column<SqlNVarchar> Language = new Column<SqlNVarchar>("language");
        
        public static readonly Column<SqlInt> LanguageId = new Column<SqlInt>("language_id");
        
        public static readonly Column<SqlInt> StoplistId = new Column<SqlInt>("stoplist_id");
        
        public static readonly Column<SqlNVarchar> Stopword = new Column<SqlNVarchar>("stopword");
    }
}
