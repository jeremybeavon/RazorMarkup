namespace RazorMarkup.Database.SqlServer.Create.Credential
{
    public interface ICreateCredentialStatement : IHideObjectMethods
    {
        ICreateCredentialSecret WithIdentity(string identityName);
    }
}
