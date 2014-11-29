namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseEncryptionOption<TOptions> : IHideObjectMethods
    {
        IBackupDatabaseOptionsAnd<TOptions> ServerCertificate(CertificateName certificateName);

        IBackupDatabaseOptionsAnd<TOptions> ServerAsymmetricKey(AsymmetricKeyName asymmetricKeyName);
    }
}
