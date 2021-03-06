using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerEventSessionFields
    {
        public static readonly ViewName ViewName = new ViewName("sys.server_event_session_fields");
        
        public static readonly Column<SqlInt> EventSessionId = new Column<SqlInt>("event_session_id");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlVariant> Value = new Column<SqlVariant>("value");
    }
}
