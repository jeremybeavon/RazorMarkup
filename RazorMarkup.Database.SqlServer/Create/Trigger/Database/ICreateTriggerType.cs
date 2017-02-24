namespace RazorMarkup.Database.SqlServer.Create.Trigger.Database
{
    public interface ICreateTriggerType : IHideObjectMethods
    {
        ICreateTriggerTypeAnd For(EventTypeName eventType);

        ICreateTriggerTypeAnd For(EventGroupName eventGroup);

        ICreateTriggerTypeAnd After(EventTypeName eventType);

        ICreateTriggerTypeAnd After(EventGroupName eventGroup);
    }
}
