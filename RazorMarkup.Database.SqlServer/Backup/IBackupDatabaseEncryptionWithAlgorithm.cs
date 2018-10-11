namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseEncryptionWithAlgorithm<TOptions> : IBackupDatabaseOptionsAnd<TOptions>
        where TOptions : class, IBackupDatabaseOptions<TOptions>
    {
        IBackupDatabaseEncryptionAlgorithm<TOptions> Algorithm();
    }
}
