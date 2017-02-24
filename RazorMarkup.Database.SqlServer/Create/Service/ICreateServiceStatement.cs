namespace RazorMarkup.Database.SqlServer.Create.Service
{
    public interface ICreateServiceStatement : ICreateServiceOnQueue
    {
        ICreateServiceOnQueue Authorization(string ownerName);
    }
}
