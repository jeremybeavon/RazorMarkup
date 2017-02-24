namespace RazorMarkup.Database.SqlServer.Create.Trigger.AllServer
{
    public interface ICreateTriggerTypeAnd : ICreateTriggerAs
    {
        ICreateTriggerTypeAnd And(EventTypeName eventType);

        ICreateTriggerTypeAnd And(EventGroupName eventType);
    }
}
