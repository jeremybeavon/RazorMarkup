namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseEncryptionWithAlgorithm<TOptions> : IHideObjectMethods
    {
        IBackupDatabaseEncryptionAlgorithm<TOptions> Algorithm();
    }
}
