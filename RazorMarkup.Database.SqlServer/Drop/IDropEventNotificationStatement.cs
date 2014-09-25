namespace RazorMarkup.Database.SqlServer.Drop
{
    public interface IDropEventNotificationStatement : IHideObjectMethods
    {
        IDropEventNotificationStatement And(EventNotificationName eventNotificationName);

        ISqlString OnServer();

        ISqlString OnDatabase();

        ISqlString OnQueue(QueueName queueName);
    }
}
