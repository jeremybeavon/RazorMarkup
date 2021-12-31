using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ServiceMessageTypes
    {
        public static readonly ViewName ViewName = new("sys.service_message_types");

        public static readonly Column<SqlInt> MessageTypeId = new("message_type_id");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlInt> PrincipalId = new("principal_id");

        public static readonly Column<SqlChar> Validation = new("validation");

        public static readonly Column<SqlNVarchar> ValidationDesc = new("validation_desc");

        public static readonly Column<SqlInt> XmlCollectionId = new("xml_collection_id");
    }
}
