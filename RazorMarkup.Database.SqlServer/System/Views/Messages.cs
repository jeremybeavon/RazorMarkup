using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Messages
    {
        public static readonly ViewName ViewName = new ViewName("sys.messages");
        
        public static readonly Column<SqlBit> IsEventLogged = new Column<SqlBit>("is_event_logged");
        
        public static readonly Column<SqlSmallInt> LanguageId = new Column<SqlSmallInt>("language_id");
        
        public static readonly Column<SqlInt> MessageId = new Column<SqlInt>("message_id");
        
        public static readonly Column<SqlTinyInt> Severity = new Column<SqlTinyInt>("severity");
        
        public static readonly Column<SqlNVarchar> Text = new Column<SqlNVarchar>("text");
    }
}
