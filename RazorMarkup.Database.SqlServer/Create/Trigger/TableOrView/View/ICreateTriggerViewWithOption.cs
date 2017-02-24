namespace RazorMarkup.Database.SqlServer.Create.Trigger.TableOrView.View
{
    public interface ICreateTriggerViewWithOption : IHideObjectMethods
    {
        ICreateTriggerViewWithAnd Encryption();

        ICreateTriggerViewWithAnd ExecuteAs(UserName userName);
    }
}
