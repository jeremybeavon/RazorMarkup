namespace RazorMarkup.Database.SqlServer.Create.Queue
{
    public interface ICreateQueueWithActivationMaxQueueReaders : IHideObjectMethods
    {
        ICreateQueueWithActivationMaxQueueReadersAnd MaxQueueReaders(int maxQueueReaders);
    }
}
