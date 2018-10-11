namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseEncryptionWithAlgorithm<TOptions> : IBackupDatabaseOptionsAnd<TOptions>
    {
        IBackupDatabaseEncryptionAlgorithm<TOptions> Algorithm();
    }
}
