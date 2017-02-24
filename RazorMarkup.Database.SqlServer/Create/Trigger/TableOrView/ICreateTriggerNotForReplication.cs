namespace RazorMarkup.Database.SqlServer.Create.Trigger.TableOrView
{
    public interface ICreateTriggerNotForReplication : ICreateTriggerAs
    {
        ICreateTriggerAs NotForReplication();
    }
}
