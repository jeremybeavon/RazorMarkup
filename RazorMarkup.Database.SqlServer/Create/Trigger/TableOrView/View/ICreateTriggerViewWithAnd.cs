namespace RazorMarkup.Database.SqlServer.Create.Trigger.TableOrView.View
{
    public interface ICreateTriggerViewWithAnd : ICreateTriggerType
    {
        ICreateTriggerViewWithOption And();
    }
}
