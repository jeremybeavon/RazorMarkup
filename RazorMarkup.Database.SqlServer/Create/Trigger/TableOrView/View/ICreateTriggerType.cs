namespace RazorMarkup.Database.SqlServer.Create.Trigger.TableOrView.View
{
    public interface ICreateTriggerType : IHideObjectMethods
    {
        ICreateTriggerEventType InsteadOf();
    }
}
