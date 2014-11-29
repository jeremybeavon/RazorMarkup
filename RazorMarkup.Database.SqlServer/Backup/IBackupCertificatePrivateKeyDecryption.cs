namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupCertificatePrivateKeyDecryption : IHideObjectMethods, ISqlString
    {
        ISqlString AndDecryptionByPassword(string decryptionPassword);
    }
}
