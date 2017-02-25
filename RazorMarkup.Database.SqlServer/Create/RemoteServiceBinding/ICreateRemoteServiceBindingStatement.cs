namespace RazorMarkup.Database.SqlServer.Create.RemoteServiceBinding
{
    public interface ICreateRemoteServiceBindingStatement : ICreateRemoteServiceBindingToService
    {
        ICreateRemoteServiceBindingToService Authorization(string ownerName);
    }
}
