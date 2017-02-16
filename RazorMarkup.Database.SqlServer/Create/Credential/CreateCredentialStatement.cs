using System;

namespace RazorMarkup.Database.SqlServer.Create.Credential
{
    internal sealed class CreateCredentialStatement : AbstractStatement<CreateCredentialStatementBuilder>,
        ICreateCredentialStatement
    {
        public CreateCredentialStatement(CreateCredentialStatementBuilder statement)
            : base(statement)
        {
        }

        public ICreateCredentialSecret WithIdentity(string identityName)
        {
            Statement.IdentityName = identityName;
            Statement.Append((ICreateCredentialStatement input) => input.WithIdentity(null), new RawStatementBuilder(identityName));
            return new CreateCredentialSecret(Statement);
        }
    }
}
