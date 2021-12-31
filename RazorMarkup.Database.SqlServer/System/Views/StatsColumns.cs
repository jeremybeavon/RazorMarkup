using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class StatsColumns
    {
        public static readonly ViewName ViewName = new("sys.stats_columns");

        public static readonly Column<SqlInt> ColumnId = new("column_id");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> StatsColumnId = new("stats_column_id");

        public static readonly Column<SqlInt> StatsId = new("stats_id");
    }
}
