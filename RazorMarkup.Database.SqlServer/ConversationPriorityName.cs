namespace RazorMarkup.Database.SqlServer
{
    public sealed class ConversationPriorityName : SqlString
    {
        public ConversationPriorityName(string conversationPriorityName)
            : base(conversationPriorityName)
        {
        }
    }
}
