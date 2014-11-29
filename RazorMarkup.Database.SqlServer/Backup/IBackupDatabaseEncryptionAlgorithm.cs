namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseEncryptionAlgorithm<TOptions> : IHideObjectMethods
    {
        IBackupDatabaseEncryptionOption<TOptions> Aes128();

        IBackupDatabaseEncryptionOption<TOptions> Aes192();

        IBackupDatabaseEncryptionOption<TOptions> Aes256();

        IBackupDatabaseEncryptionOption<TOptions> TripleDes3Key();
    }
}
