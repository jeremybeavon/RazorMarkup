namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupCertificateToFile : IHideObjectMethods
    {
        IBackupCertificateWithPrivateKey ToFile(string pathToFile);
    }
}
