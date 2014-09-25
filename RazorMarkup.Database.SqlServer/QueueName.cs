namespace RazorMarkup.Database.SqlServer
{
    public sealed class QueueName : SqlString
    {
        public QueueName(string queueName)
            : base(queueName)
        {
        }
    }
}
