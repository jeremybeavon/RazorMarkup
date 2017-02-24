namespace RazorMarkup.Database.SqlServer.Create.Trigger.TableOrView
{
    public interface ICreateTriggerEventTypeAnd : ICreateTriggerNotForReplication
    {
        ICreateTriggerEventType And();
    }
}
