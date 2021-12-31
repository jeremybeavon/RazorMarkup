using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerEventSessionTargets
    {
        public static readonly ViewName ViewName = new("sys.server_event_session_targets");

        public static readonly Column<SqlInt> EventSessionId = new("event_session_id");

        public static readonly Column<SqlNVarchar> Module = new("module");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlNVarchar> Package = new("package");

        public static readonly Column<SqlInt> TargetId = new("target_id");
    }
}
