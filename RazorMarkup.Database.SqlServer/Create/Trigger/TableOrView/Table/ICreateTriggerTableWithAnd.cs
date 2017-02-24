namespace RazorMarkup.Database.SqlServer.Create.Trigger.TableOrView.Table
{
    public interface ICreateTriggerTableWithAnd : ICreateTriggerType
    {
        ICreateTriggerTableWithOption And();
    }
}
