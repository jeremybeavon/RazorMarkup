using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class TriggerEventTypes
    {
        public static readonly ViewName ViewName = new("sys.trigger_event_types");

        public static readonly Column<SqlInt> ParentType = new("parent_type");

        public static readonly Column<SqlInt> Type = new("type");

        public static readonly Column<SqlNVarchar> TypeName = new("type_name");
    }
}
