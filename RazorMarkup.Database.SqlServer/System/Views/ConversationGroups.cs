using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ConversationGroups
    {
        public static readonly ViewName ViewName = new ViewName("sys.conversation_groups");
        
        public static readonly Column<SqlUniqueIdentifier> ConversationGroupId = new Column<SqlUniqueIdentifier>("conversation_group_id");
        
        public static readonly Column<SqlBit> IsSystem = new Column<SqlBit>("is_system");
        
        public static readonly Column<SqlInt> ServiceId = new Column<SqlInt>("service_id");
    }
}
