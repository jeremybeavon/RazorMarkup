namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupStatements : IHideObjectMethods
    {
        IBackupCertificateToFile Certificate(CertificateName certificateName);

        IBackupDatabase Database(DatabaseName databaseName);

        IBackupDatabase Database(VariableName databaseVariableName);

        IBackupMasterKeyToFile MasterKey();

        IBackupLog Log(DatabaseName databaseName);

        IBackupLog Log(VariableName databaseVariableName);

        IBackupServiceMasterKeyToFile ServiceMasterKey();
    }
}
