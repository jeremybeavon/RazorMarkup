namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupCertificateStatementBuilder : AbstractStatementBuilder
    {
        public BackupCertificateStatementBuilder(CertificateName certificateName)
            : base(new ExpressionBuilder())
        {
            CertificateName = certificateName;
        }

        public CertificateName CertificateName { get; private set; }

        public string PathToFile { get; set; }

        public string PathToPrivateKeyFile { get; set; }

        public string EncryptionPassword { get; set; }

        public string DecryptionPassword { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append("BACKUP CERTIFICATE ");
            sqlBuilder.Append(CertificateName.ToSqlString());
            sqlBuilder.Append(" TO FILE = '");
            sqlBuilder.Append(PathToFile);
            sqlBuilder.Append("'");
            if (PathToPrivateKeyFile != null)
            {
                sqlBuilder.AppendIndent().Append("WITH PRIVATE KEY");
                sqlBuilder.AppendIndent().Append("(");
                using (sqlBuilder.IncrementIndent())
                {
                    sqlBuilder.AppendIndent().Append("FILE = '");
                    sqlBuilder.Append(PathToPrivateKeyFile);
                    sqlBuilder.Append("',");
                    sqlBuilder.AppendIndent().Append("ENCRYPTION BY PASSWORD = '");
                    sqlBuilder.Append(EncryptionPassword);
                    sqlBuilder.Append("'");
                    if (DecryptionPassword != null)
                    {
                        sqlBuilder.Append(",");
                        sqlBuilder.AppendIndent().Append("DECRYPTION BY PASSWORD = '");
                        sqlBuilder.Append(DecryptionPassword);
                        sqlBuilder.Append("'");
                    }
                }

                sqlBuilder.AppendIndent().Append(")");
            }
        }
    }
}
