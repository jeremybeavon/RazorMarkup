namespace RazorMarkup.Database.SqlServer.Create.Trigger.AllServer
{
    public interface ICreateTriggerType : IHideObjectMethods
    {
        ICreateTriggerTypeAnd For(EventTypeName eventType);

        ICreateTriggerTypeAnd For(EventGroupName eventGroup);

        ICreateTriggerAs ForLogon();

        ICreateTriggerTypeAnd After(EventTypeName eventType);

        ICreateTriggerTypeAnd After(EventGroupName eventGroup);

        ICreateTriggerAs AfterLogon();
    }
}
