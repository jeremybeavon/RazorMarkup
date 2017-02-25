namespace RazorMarkup.Database.SqlServer.Create.Queue
{
    public interface ICreateQueueWithOptionOnOff : IHideObjectMethods
    {
        ICreateQueueWithAnd On();

        ICreateQueueWithAnd Off();
    }
}
