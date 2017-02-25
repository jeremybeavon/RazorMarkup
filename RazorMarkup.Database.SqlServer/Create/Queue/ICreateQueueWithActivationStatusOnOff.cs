namespace RazorMarkup.Database.SqlServer.Create.Queue
{
    public interface ICreateQueueWithActivationStatusOnOff : IHideObjectMethods
    {
        ICreateQueueWithActivationStatusAnd On();

        ICreateQueueWithActivationStatusAnd Off();
    }
}
