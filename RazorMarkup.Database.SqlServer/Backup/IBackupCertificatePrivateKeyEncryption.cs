namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupCertificatePrivateKeyEncryption : IHideObjectMethods
    {
        IBackupCertificatePrivateKeyDecryption AndEncryptionByPassword(string encryptionPassword);
    }
}
