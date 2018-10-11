namespace RazorMarkup.Database.SqlServer.Backup
{
    internal class BackupDatabaseOptionsAnd<TOptions> : AbstractDatabaseOptions<TOptions>,
        IBackupDatabaseOptionsAnd<TOptions>
    {
        public BackupDatabaseOptionsAnd(BackupDatabaseStatementBuilder statement, TOptions options)
            : base(statement, options)
        {
        }

        public virtual TOptions And()
        {
            Statement.Append((IBackupDatabaseOptionsAnd<TOptions> input) => input.And());
            return Options;
        }
    }
}
