namespace RazorMarkup.Database.SqlServer.Create.Queue
{
    public interface ICreateQueueStatement : ICreateQueueOn
    {
        ICreateQueueWithOption With();
    }
}
