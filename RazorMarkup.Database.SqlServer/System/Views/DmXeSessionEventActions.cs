using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeSessionEventActions
    {
        public static readonly ViewName ViewName = new("sys.dm_xe_session_event_actions");

        public static readonly Column<SqlNVarchar> ActionName = new("action_name");

        public static readonly Column<SqlUniqueIdentifier> ActionPackageGuid = new("action_package_guid");

        public static readonly Column<SqlNVarchar> EventName = new("event_name");

        public static readonly Column<SqlUniqueIdentifier> EventPackageGuid = new("event_package_guid");

        public static readonly Column<SqlVarbinary> EventSessionAddress = new("event_session_address");
    }
}
