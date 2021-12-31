using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeSessionEvents
    {
        public static readonly ViewName ViewName = new("sys.dm_xe_session_events");

        public static readonly Column<SqlNVarchar> EventName = new("event_name");

        public static readonly Column<SqlUniqueIdentifier> EventPackageGuid = new("event_package_guid");

        public static readonly Column<SqlNVarchar> EventPredicate = new("event_predicate");

        public static readonly Column<SqlVarbinary> EventSessionAddress = new("event_session_address");
    }
}
