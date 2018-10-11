namespace RazorMarkup.Database.SqlServer.Backup
{
    internal class BackupDatabaseWithOptions<TOptions> : AbstractDatabaseOptions<TOptions>,
        IBackupDatabaseWithOptions<TOptions>
        where TOptions : class, IBackupDatabaseOptions<TOptions>
    {
        public BackupDatabaseWithOptions(BackupDatabaseStatementBuilder input, TOptions options)
            : base(input, options)
        {
        }
        
        public TOptions With()
        {
            Statement.Append((IBackupDatabaseWithOptions<TOptions> input) => input.With());
            return Options;
        }
    }
}
