using RazorMarkup.Database.SqlServer.Types;

namespace RazorMarkup.Database.SqlServer.System.Views
{
    public sealed class ConversationGroups
    {
        public static readonly ViewName ViewName = new("sys.conversation_groups");

        public static readonly Column<SqlUniqueIdentifier> ConversationGroupId = new("conversation_group_id");

        public static readonly Column<SqlBit> IsSystem = new("is_system");

        public static readonly Column<SqlInt> ServiceId = new("service_id");
    }
}
