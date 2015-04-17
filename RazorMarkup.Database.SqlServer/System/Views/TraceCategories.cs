using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TraceCategories
    {
        public static readonly ViewName ViewName = new ViewName("sys.trace_categories");
        
        public static readonly Column<SqlSmallInt> CategoryId = new Column<SqlSmallInt>("category_id");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
        
        public static readonly Column<SqlTinyInt> Type = new Column<SqlTinyInt>("type");
    }
}
