namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseWithOptions<TOptions> : ISqlString
    {
        TOptions With();
    }
}
