namespace RazorMarkup.Database.SqlServer.Create.Credential
{
    internal class CreateCredentialForCryptographicProvider : AbstractStatement<CreateCredentialStatementBuilder>,
        ICreateCredentialForCryptographicProvider
    {
        public CreateCredentialForCryptographicProvider(CreateCredentialStatementBuilder statement)
            : base(statement)
        {
        }

        public ISqlString ForCryptographicProvider(CryptographicProviderName cryptographicProviderName)
        {
            Statement.CryptographicProviderName = cryptographicProviderName;
            Statement.Append(
                (ICreateCredentialForCryptographicProvider input) => input.ForCryptographicProvider(null),
                cryptographicProviderName);
            return this;
        }
    }
}
