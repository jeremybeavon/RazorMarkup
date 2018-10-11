namespace RazorMarkup.Database.SqlServer.Backup
{
    internal class BackupDatabase : BackupDatabaseTo<IBackupDatabaseOptions>,
        IBackupDatabase
    {
        public BackupDatabase(BackupDatabaseStatementBuilder input)
            : base(input, new BackupDatabaseOptions(input))
        {
        }
    }
}
