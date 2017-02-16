namespace RazorMarkup.Database.SqlServer.Create.EventNotification
{
    public interface ICreateEventNotificationOn : IHideObjectMethods
    {
        ICreateEventNotificationWithFanIn Server();

        ICreateEventNotificationWithFanIn Database();

        ICreateEventNotificationWithFanIn Queue(QueueName queueName);
    }
}
