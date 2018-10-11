namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupDatabaseOptions : BackupDatabaseOptions<IBackupDatabaseOptions>,
        IBackupDatabaseOptions
    {
        public BackupDatabaseOptions(BackupDatabaseStatementBuilder statement)
            : base(statement, null)
        {
            Options = this;
        }

        public IBackupDatabaseOptionsAnd<IBackupDatabaseOptions> Differential()
        {
            Statement.Append((IBackupDatabaseOptions input) => input.Differential());
            Statement.Differential = true;
            return new BackupDatabaseOptionsAnd<IBackupDatabaseOptions>(Statement, Options);
        }
    }
}
