namespace RazorMarkup.Database.SqlServer.Create.Queue
{
    public interface ICreateQueueWithAnd : ICreateQueueOn
    {
        ICreateQueueWithOption And();
    }
}
