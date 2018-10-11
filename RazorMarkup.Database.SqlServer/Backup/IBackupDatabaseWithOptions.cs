namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseWithOptions<TOptions> : ISqlString
        where TOptions : class, IBackupDatabaseOptions<TOptions>
    {
        TOptions With();
    }
}
