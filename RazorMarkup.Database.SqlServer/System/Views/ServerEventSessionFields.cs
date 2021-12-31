using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerEventSessionFields
    {
        public static readonly ViewName ViewName = new("sys.server_event_session_fields");

        public static readonly Column<SqlInt> EventSessionId = new("event_session_id");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlVariant> Value = new("value");
    }
}
