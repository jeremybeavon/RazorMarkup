namespace RazorMarkup.Database.SqlServer.Create.EventNotification
{
    public interface ICreateEventNotificationForAnd : ICreateEventNotificationToService
    {
        ICreateEventNotificationForAnd And(EventTypeName eventType);

        ICreateEventNotificationForAnd And(EventGroupName eventGroup);
    }
}
