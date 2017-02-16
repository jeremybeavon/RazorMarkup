namespace RazorMarkup.Database.SqlServer
{
    public sealed class EventGroupName : SqlString
    {
        public EventGroupName(string eventGroupName)
            : base(eventGroupName)
        {
        }
    }
}
