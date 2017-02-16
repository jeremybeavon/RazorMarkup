namespace RazorMarkup.Database.SqlServer.Create.Credential
{
    public interface ICreateCredentialSecret : ICreateCredentialForCryptographicProvider
    {
        ICreateCredentialForCryptographicProvider Secret(string secret);
    }
}
