namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupStatements : IHideObjectMethods
    {
        IBackupMasterKeyToFile MasterKey();

        IBackupServiceMasterKeyToFile ServiceMasterKey();

        IBackupCertificateToFile Certificate(CertificateName certificateName);

        IBackupDatabase Database(DatabaseName databaseName);
    }
}
