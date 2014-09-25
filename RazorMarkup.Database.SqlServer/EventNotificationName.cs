namespace RazorMarkup.Database.SqlServer
{
    public sealed class EventNotificationName : SqlString
    {
        public EventNotificationName(string eventNotificationName)
            : base(eventNotificationName)
        {
        }
    }
}
