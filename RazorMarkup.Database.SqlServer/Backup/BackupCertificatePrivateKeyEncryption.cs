namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupCertificatePrivateKeyEncryption : AbstractStatement<BackupCertificateStatementBuilder>,
        IBackupCertificatePrivateKeyEncryption
    {
        public BackupCertificatePrivateKeyEncryption(BackupCertificateStatementBuilder input)
            : base(input)
        {
        }
        
        public IBackupCertificatePrivateKeyDecryption AndEncryptionByPassword(string encryptionPassword)
        {
            Statement.Append(
                (IBackupCertificatePrivateKeyEncryption input) => input.AndEncryptionByPassword(null),
                new RawStatementBuilder(encryptionPassword));
            Statement.EncryptionPassword = encryptionPassword;
            return new BackupCertificatePrivateKeyDecryption(Statement);
        }
    }
}
