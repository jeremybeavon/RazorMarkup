namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseEncryptionOption<TOptions> : IHideObjectMethods
        where TOptions : class, IBackupDatabaseOptions<TOptions>
    {
        IBackupDatabaseOptionsAnd<TOptions> ServerCertificate(CertificateName certificateName);

        IBackupDatabaseOptionsAnd<TOptions> ServerAsymmetricKey(AsymmetricKeyName asymmetricKeyName);
    }
}
