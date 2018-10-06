namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupCertificatePrivateKeyFile : AbstractStatement<BackupCertificateStatementBuilder>,
        IBackupCertificatePrivateKeyFile
    {
        public BackupCertificatePrivateKeyFile(BackupCertificateStatementBuilder input)
            : base(input)
        {
        }
        
        public IBackupCertificatePrivateKeyEncryption File(string pathToPrivateKeyFile)
        {
            Statement.Append(
                (IBackupCertificatePrivateKeyFile input) => input.File(null),
                new RawStatementBuilder(pathToPrivateKeyFile));
            Statement.PathToPrivateKeyFile = pathToPrivateKeyFile;
            return new BackupCertificatePrivateKeyEncryption(Statement);
        }
    }
}
