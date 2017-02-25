namespace RazorMarkup.Database.SqlServer.Create.Queue
{
    public interface ICreateQueueWithActivationStatus : ICreateQueueWithActivationProcedureName
    {
        ICreateQueueWithActivationStatusOnOff Status();
    }
}
