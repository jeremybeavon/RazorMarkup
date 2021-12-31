namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupCertificateToFile : AbstractStatement<BackupCertificateStatementBuilder>,
        IBackupCertificateToFile
    {
        public BackupCertificateToFile(CertificateName certificateName)
            : base(new BackupCertificateStatementBuilder(certificateName))
        {
            Statement.Initialize(() => Sql.Backup().Certificate(null), certificateName);
        }

        public IBackupCertificatePrivateKeyEncryption File(string pathToPrivateKeyFile)
        {
            Statement.Append(
                (IBackupCertificatePrivateKeyFile input) => input.File(null),
                new RawStatementBuilder(pathToPrivateKeyFile));
            Statement.PathToPrivateKeyFile = pathToPrivateKeyFile;
            return new BackupCertificatePrivateKeyEncryption(Statement);
        }

        public IBackupCertificateWithPrivateKey ToFile(string pathToFile)
        {
            Statement.Append((IBackupCertificateToFile input) => input.ToFile(null), new RawStatementBuilder(pathToFile));
            Statement.PathToFile = pathToFile;
            return new BackupCertificateWithPrivateKey(Statement);
        }
    }
}
