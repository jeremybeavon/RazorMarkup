namespace RazorMarkup.Database.SqlServer.Create.Queue
{
    public interface ICreateQueueWithPoisonMessageHandlingStatusOnOff : IHideObjectMethods
    {
        ICreateQueueWithAnd On();

        ICreateQueueWithAnd Off();
    }
}
