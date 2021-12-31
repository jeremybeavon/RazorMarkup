namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupCertificateWithPrivateKey : AbstractStatement<BackupCertificateStatementBuilder>,
        IBackupCertificateWithPrivateKey
    {
        public BackupCertificateWithPrivateKey(BackupCertificateStatementBuilder input)
            : base(input)
        {
        }

        public IBackupCertificatePrivateKeyFile WithPrivateKey()
        {
            Statement.Append((IBackupCertificateWithPrivateKey input) => input.WithPrivateKey());
            return new BackupCertificatePrivateKeyFile(Statement);
        }
    }
}
