namespace RazorMarkup.Database.SqlServer.Create.Trigger.TableOrView.Table
{
    public interface ICreateTriggerTableWithOption : IHideObjectMethods
    {
        ICreateTriggerTableWithAnd Encryption();

        ICreateTriggerTableWithAnd ExecuteAs(UserName userName);
    }
}
