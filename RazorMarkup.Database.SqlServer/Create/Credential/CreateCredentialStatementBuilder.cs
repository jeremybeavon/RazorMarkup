using System;

namespace RazorMarkup.Database.SqlServer.Create.Credential
{
    internal sealed class CreateCredentialStatementBuilder : AbstractStatementBuilder
    {
        public CreateCredentialStatementBuilder(CredentialName name)
            : base(new ExpressionBuilder())
        {
            Name = name;
        }

        public CredentialName Name { get; private set; }

        public string IdentityName { get; set; }

        public string Secret { get; set; }

        public CryptographicProviderName CryptographicProviderName { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append("CREATE CREDENTIAL ");
            sqlBuilder.Append(Name.ToSqlString());
            sqlBuilder.Append(" WITH IDENTITY '");
            sqlBuilder.Append(IdentityName);
            sqlBuilder.Append("'");
            IDisposable indent = null;
            if (!string.IsNullOrWhiteSpace(Secret))
            {
                sqlBuilder.Append(",");
                indent = sqlBuilder.IncrementIndent();
                sqlBuilder.AppendIndent();
                sqlBuilder.Append("SECRET = '");
                sqlBuilder.Append(Secret);
                sqlBuilder.Append("'");
            }

            if (CryptographicProviderName != null)
            {
                if (indent == null)
                {
                    indent = sqlBuilder.IncrementIndent();
                }

                sqlBuilder.AppendIndent();
                sqlBuilder.Append("FOR CRYPTOGRAPHIC PROVIDER ");
                sqlBuilder.Append(CryptographicProviderName.ToSqlString());
            }

            if (indent != null)
            {
                indent.Dispose();
            }
        }
    }
}
