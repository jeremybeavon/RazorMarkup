namespace RazorMarkup.Database.SqlServer.Create.EventNotification
{
    public interface ICreateEventNotificationToService : IHideObjectMethods
    {
        ISqlString ToService(string brokerService, string brokerInstanceSpecifier);

        ISqlString ToService(string brokerService, CurrentDatabaseOption currentDatabase);
    }
}
