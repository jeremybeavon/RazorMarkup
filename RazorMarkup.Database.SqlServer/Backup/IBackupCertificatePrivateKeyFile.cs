namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupCertificatePrivateKeyFile : IHideObjectMethods
    {
        IBackupCertificatePrivateKeyEncryption File(string pathToPrivateKeyFile);
    }
}
