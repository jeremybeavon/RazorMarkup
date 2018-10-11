namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupDatabaseEncryptionAlgorithm<TOptions> : AbstractDatabaseOptions<TOptions>,
        IBackupDatabaseEncryptionAlgorithm<TOptions>
    {
        public BackupDatabaseEncryptionAlgorithm(BackupDatabaseStatementBuilder statement, TOptions options)
            : base(statement, options)
        {
        }

        public IBackupDatabaseEncryptionOption<TOptions> Aes128()
        {
            Statement.Append((IBackupDatabaseEncryptionAlgorithm<TOptions> input) => input.Aes128());
            Statement.EncryptionAlgorithm = "AES_128";
            return new BackupDatabaseEncryptionOption<TOptions>(Statement, Options);
        }

        public IBackupDatabaseEncryptionOption<TOptions> Aes192()
        {
            Statement.Append((IBackupDatabaseEncryptionAlgorithm<TOptions> input) => input.Aes192());
            Statement.EncryptionAlgorithm = "AES_192";
            return new BackupDatabaseEncryptionOption<TOptions>(Statement, Options);
        }

        public IBackupDatabaseEncryptionOption<TOptions> Aes256()
        {
            Statement.Append((IBackupDatabaseEncryptionAlgorithm<TOptions> input) => input.Aes256());
            Statement.EncryptionAlgorithm = "AES_256";
            return new BackupDatabaseEncryptionOption<TOptions>(Statement, Options);
        }

        public IBackupDatabaseEncryptionOption<TOptions> TripleDes3Key()
        {
            Statement.Append((IBackupDatabaseEncryptionAlgorithm<TOptions> input) => input.TripleDes3Key());
            Statement.EncryptionAlgorithm = "TRIPLE_DES_3KEY";
            return new BackupDatabaseEncryptionOption<TOptions>(Statement, Options);
        }
    }
}
