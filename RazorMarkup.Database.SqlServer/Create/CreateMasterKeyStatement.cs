namespace RazorMarkup.Database.SqlServer.Create
{
    internal sealed class CreateMasterKeyStatement : SqlBuilder, ICreateMasterKeyStatement
    {
        public CreateMasterKeyStatement()
            : base("CREATE MASTER KEY", () => Sql.Create().MasterKey())
        {
        }

        public ISqlString EncryptionByPassword(string password)
        {
            Append(string.Format(" ENCRYPTION BY PASSWORD = '{0}'", password));
            Append((ICreateMasterKeyStatement input) => input.EncryptionByPassword(null), new RawStatementBuilder(password));
            return this;
        }
    }
}
