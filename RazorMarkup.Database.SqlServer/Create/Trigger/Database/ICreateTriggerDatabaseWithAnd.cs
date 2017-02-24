namespace RazorMarkup.Database.SqlServer.Create.Trigger.Database
{
    public interface ICreateTriggerDatabaseWithAnd : ICreateTriggerType
    {
        ICreateTriggerDatabaseWithOption And();
    }
}
