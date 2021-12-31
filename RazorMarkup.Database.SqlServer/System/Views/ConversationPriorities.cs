using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ConversationPriorities
    {
        public static readonly ViewName ViewName = new("sys.conversation_priorities");

        public static readonly Column<SqlInt> LocalServiceId = new("local_service_id");

        public static readonly Column<SqlSysname> Name = new("name");

        public static readonly Column<SqlTinyInt> Priority = new("priority");

        public static readonly Column<SqlInt> PriorityId = new("priority_id");

        public static readonly Column<SqlNVarchar> RemoteServiceName = new("remote_service_name");

        public static readonly Column<SqlInt> ServiceContractId = new("service_contract_id");
    }
}
