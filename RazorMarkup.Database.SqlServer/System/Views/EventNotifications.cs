using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class EventNotifications
    {
        public static readonly ViewName ViewName = new("sys.event_notifications");

        public static readonly Column<SqlNVarchar> BrokerInstance = new("broker_instance");

        public static readonly Column<SqlDateTime> CreateDate = new("create_date");

        public static readonly Column<SqlVarbinary> CreatorSid = new("creator_sid");

        public static readonly Column<SqlDateTime> ModifyDate = new("modify_date");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> ObjectId = new("object_id");

        public static readonly Column<SqlTinyInt> ParentClass = new("parent_class");

        public static readonly Column<SqlNVarchar> ParentClassDesc = new("parent_class_desc");

        public static readonly Column<SqlInt> ParentId = new("parent_id");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlNVarchar> ServiceName = new("service_name");
    }
}
