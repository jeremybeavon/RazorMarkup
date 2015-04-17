using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerEventSessionEvents
    {
        public static readonly ViewName ViewName = new ViewName("sys.server_event_session_events");
        
        public static readonly Column<SqlInt> EventId = new Column<SqlInt>("event_id");
        
        public static readonly Column<SqlInt> EventSessionId = new Column<SqlInt>("event_session_id");
        
        public static readonly Column<SqlNVarchar> Module = new Column<SqlNVarchar>("module");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlNVarchar> Package = new Column<SqlNVarchar>("package");
        
        public static readonly Column<SqlNVarchar> Predicate = new Column<SqlNVarchar>("predicate");
        
        public static readonly Column<SqlNVarchar> PredicateXml = new Column<SqlNVarchar>("predicate_xml");
    }
}
