namespace RazorMarkup.Database.SqlServer.Create.Queue
{
    public interface ICreateQueueWithActivationExecuteAs : IHideObjectMethods
    {
        ICreateQueueWithAnd ExecuteAsSelf();

        ICreateQueueWithAnd ExecuteAs(UserName userName);

        ICreateQueueWithAnd ExecuteAsOwner();
    }
}
