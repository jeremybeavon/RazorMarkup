namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupMasterKey : SqlBuilder, IBackupMasterKeyToFile, IBackupMasterKeyEncryption
    {
        public BackupMasterKey()
            : base("BACKUP MASTER KEY")
        {
            Initialize(() => Sql.Backup().MasterKey());
        }

        public ISqlString EncryptionByPassword(string password)
        {
            AppendIndent().Append($"ENCRYPTION BY PASSWORD = '{password}'");
            Append((IBackupMasterKeyEncryption input) => input.EncryptionByPassword(null), new RawStatementBuilder(password));
            return this;
        }

        public IBackupMasterKeyEncryption ToFile(string pathToFile)
        {
            Append($" TO FILE = '{pathToFile}'");
            Append((IBackupMasterKeyToFile input) => input.ToFile(null), new RawStatementBuilder(pathToFile));
            return this;
        }
    }
}
