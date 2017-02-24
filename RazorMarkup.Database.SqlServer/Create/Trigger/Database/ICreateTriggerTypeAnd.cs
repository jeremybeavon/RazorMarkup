namespace RazorMarkup.Database.SqlServer.Create.Trigger.Database
{
    public interface ICreateTriggerTypeAnd : ICreateTriggerAs
    {
        ICreateTriggerTypeAnd And(EventTypeName eventType);

        ICreateTriggerTypeAnd And(EventGroupName eventType);
    }
}
