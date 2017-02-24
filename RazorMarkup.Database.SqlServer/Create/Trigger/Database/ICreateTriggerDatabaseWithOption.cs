namespace RazorMarkup.Database.SqlServer.Create.Trigger.Database
{
    public interface ICreateTriggerDatabaseWithOption : IHideObjectMethods
    {
        ICreateTriggerDatabaseWithAnd Encryption();

        ICreateTriggerDatabaseWithAnd ExecuteAs(UserName userName);
    }
}
