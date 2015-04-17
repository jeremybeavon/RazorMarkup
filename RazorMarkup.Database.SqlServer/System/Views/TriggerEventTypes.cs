using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TriggerEventTypes
    {
        public static readonly ViewName ViewName = new ViewName("sys.trigger_event_types");
        
        public static readonly Column<SqlInt> ParentType = new Column<SqlInt>("parent_type");
        
        public static readonly Column<SqlInt> Type = new Column<SqlInt>("type");
        
        public static readonly Column<SqlNVarchar> TypeName = new Column<SqlNVarchar>("type_name");
    }
}
