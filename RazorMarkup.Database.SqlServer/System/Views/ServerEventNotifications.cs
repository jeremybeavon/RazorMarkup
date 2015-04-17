using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServerEventNotifications
    {
        public static readonly ViewName ViewName = new ViewName("sys.server_event_notifications");
        
        public static readonly Column<SqlNVarchar> BrokerInstance = new Column<SqlNVarchar>("broker_instance");
        
        public static readonly Column<SqlDateTime> CreateDate = new Column<SqlDateTime>("create_date");
        
        public static readonly Column<SqlVarbinary> CreatorSid = new Column<SqlVarbinary>("creator_sid");
        
        public static readonly Column<SqlDateTime> ModifyDate = new Column<SqlDateTime>("modify_date");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> ObjectId = new Column<SqlInt>("object_id");
        
        public static readonly Column<SqlTinyInt> ParentClass = new Column<SqlTinyInt>("parent_class");
        
        public static readonly Column<SqlNVarchar> ParentClassDesc = new Column<SqlNVarchar>("parent_class_desc");
        
        public static readonly Column<SqlInt> ParentId = new Column<SqlInt>("parent_id");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlNVarchar> ServiceName = new Column<SqlNVarchar>("service_name");
    }
}
