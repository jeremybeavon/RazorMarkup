namespace RazorMarkup.Database.SqlServer.Create.RemoteServiceBinding
{
    public interface ICreateRemoteServiceBindingToService : IHideObjectMethods
    {
        ICreateRemoteServiceBindingWith ToService(ServiceName serviceName);
    }
}
