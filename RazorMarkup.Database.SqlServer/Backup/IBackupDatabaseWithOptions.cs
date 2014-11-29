namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseWithOptions : ISqlString
    {
        IBackupDatabaseOptions With();
    }
}
