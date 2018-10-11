namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupDatabaseEncryptionOption<TOptions> : AbstractDatabaseOptions<TOptions>,
        IBackupDatabaseEncryptionOption<TOptions>
    {
        public BackupDatabaseEncryptionOption(BackupDatabaseStatementBuilder statement, TOptions options)
            : base(statement, options)
        {
        }

        public IBackupDatabaseOptionsAnd<TOptions> ServerAsymmetricKey(AsymmetricKeyName asymmetricKeyName)
        {
            Statement.Append(
                (IBackupDatabaseEncryptionOption<TOptions> input) => input.ServerAsymmetricKey(null),
                asymmetricKeyName);
            Statement.EncryptionAsymmetricKeyName = asymmetricKeyName;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> ServerCertificate(CertificateName certificateName)
        {
            Statement.Append(
                (IBackupDatabaseEncryptionOption<TOptions> input) => input.ServerCertificate(null),
                certificateName);
            Statement.EncryptionCertificateName = certificateName;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }
    }
}
