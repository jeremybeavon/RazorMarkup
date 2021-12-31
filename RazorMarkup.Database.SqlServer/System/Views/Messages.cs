using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Messages
    {
        public static readonly ViewName ViewName = new("sys.messages");

        public static readonly Column<SqlBit> IsEventLogged = new("is_event_logged");

        public static readonly Column<SqlSmallInt> LanguageId = new("language_id");

        public static readonly Column<SqlInt> MessageId = new("message_id");

        public static readonly Column<SqlTinyInt> Severity = new("severity");

        public static readonly Column<SqlNVarchar> Text = new("text");
    }
}
