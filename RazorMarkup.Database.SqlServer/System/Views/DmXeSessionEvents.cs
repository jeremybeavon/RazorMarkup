using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class DmXeSessionEvents
    {
        public static readonly ViewName ViewName = new ViewName("sys.dm_xe_session_events");
        
        public static readonly Column<SqlNVarchar> EventName = new Column<SqlNVarchar>("event_name");
        
        public static readonly Column<SqlUniqueIdentifier> EventPackageGuid = new Column<SqlUniqueIdentifier>("event_package_guid");
        
        public static readonly Column<SqlNVarchar> EventPredicate = new Column<SqlNVarchar>("event_predicate");
        
        public static readonly Column<SqlVarbinary> EventSessionAddress = new Column<SqlVarbinary>("event_session_address");
    }
}
