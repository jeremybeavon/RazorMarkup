namespace RazorMarkup.Database.SqlServer.Create.Queue
{
    public interface ICreateQueueOn : ISqlString
    {
        ISqlString On(FileGroupName fileGroup);

        ICreateQueueOnDefault On();
    }
}
