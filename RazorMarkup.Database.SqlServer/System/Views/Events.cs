using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Events
    {
        public static readonly ViewName ViewName = new ViewName("sys.events");
        
        public static readonly Column<SqlInt> EventGroupType = new Column<SqlInt>("event_group_type");
        
        public static readonly Column<SqlNVarchar> EventGroupTypeDesc = new Column<SqlNVarchar>("event_group_type_desc");
        
        public static readonly Column<SqlBit> IsTriggerEvent = new Column<SqlBit>("is_trigger_event");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlInt> Type = new Column<SqlInt>("type");
        
        public static readonly Column<SqlNVarchar> TypeDesc = new Column<SqlNVarchar>("type_desc");
    }
}
