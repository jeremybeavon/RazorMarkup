using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerEventSessionActions
    {
        public static readonly ViewName ViewName = new("sys.server_event_session_actions");

        public static readonly Column<SqlInt> EventId = new("event_id");

        public static readonly Column<SqlInt> EventSessionId = new("event_session_id");

        public static readonly Column<SqlNVarchar> Module = new("module");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlNVarchar> Package = new("package");
    }
}
