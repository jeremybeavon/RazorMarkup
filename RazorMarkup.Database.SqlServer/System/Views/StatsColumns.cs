using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class StatsColumns
    {
        public static readonly ViewName ViewName = new ViewName("sys.stats_columns");
        
        public static readonly Column<SqlInt> ColumnId = new Column<SqlInt>("column_id");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> StatsColumnId = new Column<SqlInt>("stats_column_id");
        
        public static readonly Column<SqlInt> StatsId = new Column<SqlInt>("stats_id");
    }
}
