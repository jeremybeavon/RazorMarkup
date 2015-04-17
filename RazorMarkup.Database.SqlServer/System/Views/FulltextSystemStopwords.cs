using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextSystemStopwords
    {
        public static readonly ViewName ViewName = new ViewName("sys.fulltext_system_stopwords");
        
        public static readonly Column<SqlInt> LanguageId = new Column<SqlInt>("language_id");
        
        public static readonly Column<SqlNVarchar> Stopword = new Column<SqlNVarchar>("stopword");
    }
}
