namespace RazorMarkup.Database.SqlServer.Create.RemoteServiceBinding
{
    public interface ICreateRemoteServiceBindingWithOnOff : IHideObjectMethods
    {
        ISqlString On();

        ISqlString Off();
    }
}
