namespace RazorMarkup.Database.SqlServer
{
    public sealed class EventTypeName : SqlString
    {
        public EventTypeName(string eventTypeName)
            : base(eventTypeName)
        {
        }
    }
}
