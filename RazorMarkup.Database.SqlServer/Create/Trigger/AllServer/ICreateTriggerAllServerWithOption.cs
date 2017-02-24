namespace RazorMarkup.Database.SqlServer.Create.Trigger.AllServer
{
    public interface ICreateTriggerAllServerWithOption : IHideObjectMethods
    {
        ICreateTriggerAllServerWithAnd Encryption();

        ICreateTriggerAllServerWithAnd ExecuteAs(UserName userName);
    }
}
