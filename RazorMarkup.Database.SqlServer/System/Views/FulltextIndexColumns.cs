using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextIndexColumns
    {
        public static readonly ViewName ViewName = new ViewName("sys.fulltext_index_columns");
        
        public static readonly Column<SqlInt> ColumnId = new Column<SqlInt>("column_id");
        
        public static readonly Column<SqlInt> LanguageId = new Column<SqlInt>("language_id");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> StatisticalSemantics = new Column<SqlInt>("statistical_semantics");
        
        public static readonly Column<SqlInt> TypeColumnId = new Column<SqlInt>("type_column_id");
    }
}
