namespace RazorMarkup.Database.SqlServer.Create.Trigger.TableOrView.Table
{
    public interface ICreateTriggerType : IHideObjectMethods
    {
        ICreateTriggerEventType For();

        ICreateTriggerEventType After();

        ICreateTriggerEventType InsteadOf();
    }
}
