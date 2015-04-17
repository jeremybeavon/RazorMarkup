using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ConversationPriorities
    {
        public static readonly ViewName ViewName = new ViewName("sys.conversation_priorities");
        
        public static readonly Column<SqlInt> LocalServiceId = new Column<SqlInt>("local_service_id");
        
        public static readonly Column<SqlSysname> Name = new Column<SqlSysname>("name");
        
        public static readonly Column<SqlTinyInt> Priority = new Column<SqlTinyInt>("priority");
        
        public static readonly Column<SqlInt> PriorityId = new Column<SqlInt>("priority_id");
        
        public static readonly Column<SqlNVarchar> RemoteServiceName = new Column<SqlNVarchar>("remote_service_name");
        
        public static readonly Column<SqlInt> ServiceContractId = new Column<SqlInt>("service_contract_id");
    }
}
