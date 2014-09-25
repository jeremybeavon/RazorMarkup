namespace RazorMarkup.Database.SqlServer
{
    public sealed class EventSessionName : SqlString
    {
        public EventSessionName(string eventSessionName)
            : base(eventSessionName)
        {
        }
    }
}
