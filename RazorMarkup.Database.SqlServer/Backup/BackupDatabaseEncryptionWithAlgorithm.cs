namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupDatabaseEncryptionWithAlgorithm<TOptions> : BackupDatabaseOptionsAnd<TOptions>,
        IBackupDatabaseEncryptionWithAlgorithm<TOptions>
        where TOptions : class, IBackupDatabaseOptions<TOptions>
    {
        public BackupDatabaseEncryptionWithAlgorithm(BackupDatabaseStatementBuilder statement, TOptions options)
            : base(statement, options)
        {
        }
        
        public IBackupDatabaseEncryptionAlgorithm<TOptions> Algorithm()
        {
            Statement.Append((IBackupDatabaseEncryptionWithAlgorithm<TOptions> input) => input.Algorithm());
            return new BackupDatabaseEncryptionAlgorithm<TOptions>(Statement, Options);
        }

        public override TOptions And()
        {
            Statement.Encryption = true;
            return base.And();
        }
    }
}
