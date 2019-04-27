namespace RazorMarkup.Database.SqlServer.Backup
{
    internal abstract class AbstractDatabaseOptions<TOptions> : AbstractStatement<BackupDatabaseStatementBuilder>
    {
        protected AbstractDatabaseOptions(BackupDatabaseStatementBuilder statement, TOptions options)
            : base(statement)
        {
            Options = options;
        }

        protected TOptions Options { get; set; }
    }
}
