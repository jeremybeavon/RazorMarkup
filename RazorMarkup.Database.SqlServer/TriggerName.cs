namespace RazorMarkup.Database.SqlServer
{
    public sealed class TriggerName : SqlString
    {
        public TriggerName(string triggerName)
            : base(triggerName)
        {
        }
    }
}
