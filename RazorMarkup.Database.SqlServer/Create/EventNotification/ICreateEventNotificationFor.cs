namespace RazorMarkup.Database.SqlServer.Create.EventNotification
{
    public interface ICreateEventNotificationFor : IHideObjectMethods
    {
        ICreateEventNotificationForAnd For(EventTypeName eventType);

        ICreateEventNotificationForAnd For(EventGroupName eventGroup);
    }
}
