namespace RazorMarkup.Database.SqlServer.Create.EventNotification
{
    public interface ICreateEventNotificationWithFanIn : ICreateEventNotificationFor
    {
        ICreateEventNotificationFor WithFanIn();
    }
}
