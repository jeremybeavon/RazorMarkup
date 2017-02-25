namespace RazorMarkup.Database.SqlServer.Create.Queue
{
    public interface ICreateQueueWithOption : IHideObjectMethods
    {
        ICreateQueueWithOptionOnOff Status();

        ICreateQueueWithOptionOnOff Retention();

        ICreateQueueWithActivationStatus Activation();

        ICreateQueueWithPoisonMessageHandlingStatus PoisonMessageHandling();
    }
}
