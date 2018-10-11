namespace RazorMarkup.Database.SqlServer.Backup
{
    internal class BackupLog : BackupDatabaseTo<IBackupLogOptions>,
        IBackupLog
    {
        public BackupLog(BackupDatabaseStatementBuilder input)
            : base(input, new BackupLogOptions(input))
        {
            input.IsBackupLogStatement = true;
        }
    }
}
