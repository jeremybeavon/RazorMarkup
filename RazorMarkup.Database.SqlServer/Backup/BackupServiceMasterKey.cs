namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupServiceMasterKey : SqlBuilder, IBackupServiceMasterKeyToFile, IBackupServiceMasterKeyEncryption
    {
        public BackupServiceMasterKey()
            : base("BACKUP SERVICE MASTER KEY")
        {
            Initialize(() => Sql.Backup().ServiceMasterKey());
        }

        public ISqlString EncryptionByPassword(string password)
        {
            AppendIndent().Append($"ENCRYPTION BY PASSWORD = '{password}'");
            Append((IBackupServiceMasterKeyEncryption input) => input.EncryptionByPassword(null), new RawStatementBuilder(password));
            return this;
        }

        public IBackupServiceMasterKeyEncryption ToFile(string pathToFile)
        {
            Append($" TO FILE = '{pathToFile}'");
            Append((IBackupServiceMasterKeyToFile input) => input.ToFile(null), new RawStatementBuilder(pathToFile));
            return this;
        }
    }
}
