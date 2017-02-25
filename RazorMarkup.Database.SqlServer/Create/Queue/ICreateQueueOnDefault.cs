namespace RazorMarkup.Database.SqlServer.Create.Queue
{
    public interface ICreateQueueOnDefault : IHideObjectMethods
    {
        ISqlString Default();
    }
}
