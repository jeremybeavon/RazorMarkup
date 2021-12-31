using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextLanguages
    {
        public static readonly ViewName ViewName = new("sys.fulltext_languages");

        public static readonly Column<SqlInt> Lcid = new("lcid");

        public static readonly Column<SqlNVarchar> Name = new("name");
    }
}
