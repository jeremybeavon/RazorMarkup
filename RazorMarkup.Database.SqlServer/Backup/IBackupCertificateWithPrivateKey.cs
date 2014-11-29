namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupCertificateWithPrivateKey : IHideObjectMethods, ISqlString
    {
        IBackupCertificatePrivateKeyFile WithPrivateKey();
    }
}
