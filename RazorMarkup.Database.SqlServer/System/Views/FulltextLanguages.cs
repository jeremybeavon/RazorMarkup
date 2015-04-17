using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class FulltextLanguages
    {
        public static readonly ViewName ViewName = new ViewName("sys.fulltext_languages");
        
        public static readonly Column<SqlInt> Lcid = new Column<SqlInt>("lcid");
        
        public static readonly Column<SqlNVarchar> Name = new Column<SqlNVarchar>("name");
    }
}
