using System;

namespace RazorMarkup.Database.SqlServer.Create.Credential
{
    internal sealed class CreateCredentialSecret : CreateCredentialForCryptographicProvider,
        ICreateCredentialSecret
    {
        public CreateCredentialSecret(CreateCredentialStatementBuilder statement)
            : base(statement)
        {
        }
        
        public ICreateCredentialForCryptographicProvider Secret(string secret)
        {
            Statement.Secret = secret;
            Statement.Append((ICreateCredentialSecret input) => input.Secret(null), new RawStatementBuilder(secret));
            return this;
        }
    }
}
