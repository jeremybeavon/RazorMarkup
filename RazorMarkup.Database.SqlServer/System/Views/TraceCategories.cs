using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TraceCategories
    {
        public static readonly ViewName ViewName = new("sys.trace_categories");

        public static readonly Column<SqlSmallInt> CategoryId = new("category_id");

        public static readonly Column<SqlNVarchar> Name = new("name");

        public static readonly Column<SqlTinyInt> Type = new("type");
    }
}
