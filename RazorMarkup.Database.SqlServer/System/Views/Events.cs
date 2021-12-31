using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class Events
    {
        public static readonly ViewName ViewName = new("sys.events");

        public static readonly Column<SqlInt> EventGroupType = new("event_group_type");

        public static readonly Column<SqlNVarchar> EventGroupTypeDesc = new("event_group_type_desc");

        public static readonly Column<SqlBit> IsTriggerEvent = new("is_trigger_event");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlInt> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeDesc = new("type_desc");
    }
}
