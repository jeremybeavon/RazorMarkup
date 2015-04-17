using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextSemanticLanguageStatisticsDatabase
    {
        public static readonly ViewName ViewName = new ViewName("sys.fulltext_semantic_language_statistics_database");
        
        public static readonly Column<SqlInt> DatabaseId = new Column<SqlInt>("database_id");
        
        public static readonly Column<SqlDateTime> RegisterDate = new Column<SqlDateTime>("register_date");
        
        public static readonly Column<SqlInt> RegisteredBy = new Column<SqlInt>("registered_by");
        
        public static readonly Column<SqlNVarchar> Version = new Column<SqlNVarchar>("version");
    }
}
