namespace RazorMarkup.Database.SqlServer
{
    public sealed class MessageTypeName : SqlString
    {
        public MessageTypeName(string messageTypeName)
            : base(messageTypeName)
        {
        }
    }
}
