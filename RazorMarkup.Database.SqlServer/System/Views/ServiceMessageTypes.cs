using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServiceMessageTypes
    {
        public static readonly ViewName ViewName = new ViewName("sys.service_message_types");
        
        public static readonly Column<SqlInt> MessageTypeId = new Column<SqlInt>("message_type_id");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlInt> PrincipalId = new Column<SqlInt>("principal_id");
        
        public static readonly Column<SqlChar> Validation = new Column<SqlChar>("validation");
        
        public static readonly Column<SqlNVarchar> ValidationDesc = new Column<SqlNVarchar>("validation_desc");
        
        public static readonly Column<SqlInt> XmlCollectionId = new Column<SqlInt>("xml_collection_id");
    }
}
