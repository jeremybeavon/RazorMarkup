using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextIndexColumns
    {
        public static readonly ViewName ViewName = new("sys.fulltext_index_columns");

        public static readonly Column<SqlInt> ColumnId = new("column_id");

        public static readonly Column<SqlInt> LanguageId = new("language_id");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> StatisticalSemantics = new("statistical_semantics");

        public static readonly Column<SqlInt> TypeColumnId = new("type_column_id");
    }
}
