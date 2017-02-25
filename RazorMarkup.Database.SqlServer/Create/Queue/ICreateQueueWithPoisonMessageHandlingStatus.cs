namespace RazorMarkup.Database.SqlServer.Create.Queue
{
    public interface ICreateQueueWithPoisonMessageHandlingStatus : IHideObjectMethods
    {
        ICreateQueueWithPoisonMessageHandlingStatusOnOff Status();
    }
}
