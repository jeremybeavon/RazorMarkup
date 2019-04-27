namespace RazorMarkup.Database.SqlServer.Create.Credential
{
    public interface ICreateCredentialForCryptographicProvider : ISqlString
    {
        ISqlString ForCryptographicProvider(CryptographicProviderName cryptographicProviderName);
    }
}
