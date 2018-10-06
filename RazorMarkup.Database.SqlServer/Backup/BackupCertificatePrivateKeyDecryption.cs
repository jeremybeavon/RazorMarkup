namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupCertificatePrivateKeyDecryption : AbstractStatement<BackupCertificateStatementBuilder>,
        IBackupCertificatePrivateKeyDecryption
    {
        public BackupCertificatePrivateKeyDecryption(BackupCertificateStatementBuilder input)
            : base(input)
        {
        }

        public ISqlString AndDecryptionByPassword(string decryptionPassword)
        {
            Statement.Append(
                (IBackupCertificatePrivateKeyDecryption input) => input.AndDecryptionByPassword(null),
                new RawStatementBuilder(decryptionPassword));
            Statement.DecryptionPassword = decryptionPassword;
            return this;
        }
    }
}
