using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerEventSessionActions
    {
        public static readonly ViewName ViewName = new ViewName("sys.server_event_session_actions");
        
        public static readonly Column<SqlInt> EventId = new Column<SqlInt>("event_id");
        
        public static readonly Column<SqlInt> EventSessionId = new Column<SqlInt>("event_session_id");
        
        public static readonly Column<SqlNVarchar> Module = new Column<SqlNVarchar>("module");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlNVarchar> Package = new Column<SqlNVarchar>("package");
    }
}
