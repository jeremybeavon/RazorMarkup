namespace RazorMarkup.Database.SqlServer.Create.RemoteServiceBinding
{
    public interface ICreateRemoteServiceBindingWithUser : IHideObjectMethods
    {
        ICreateRemoteServiceBindingWithAnd User(UserName userName);
    }
}
