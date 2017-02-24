namespace RazorMarkup.Database.SqlServer.Create.Trigger.TableOrView
{
    public interface ICreateTriggerEventType
    {
        ICreateTriggerEventTypeAnd Insert();

        ICreateTriggerEventTypeAnd Update();

        ICreateTriggerEventTypeAnd Delete();
    }
}
