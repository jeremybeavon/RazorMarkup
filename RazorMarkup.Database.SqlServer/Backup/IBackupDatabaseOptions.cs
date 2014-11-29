namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseOptions : IBackupDatabaseOptions<IBackupDatabaseOptions>
    {
        IBackupDatabaseOptionsAnd<IBackupDatabaseOptions> Differential();
    }
}
