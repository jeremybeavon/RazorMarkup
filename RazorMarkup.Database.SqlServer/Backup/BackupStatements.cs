namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupStatements : IBackupStatements
    {
        public IBackupCertificateToFile Certificate(CertificateName certificateName)
        {
            return new BackupCertificateToFile(certificateName);
        }

        public IBackupDatabase Database(DatabaseName databaseName)
        {
            return new BackupDatabase(new BackupDatabaseStatementBuilder(databaseName));
        }

        public IBackupDatabase Database(VariableName databaseVariableName)
        {
            return new BackupDatabase(new BackupDatabaseStatementBuilder(databaseVariableName));
        }

        public IBackupLog Log(DatabaseName databaseName)
        {
            return new BackupLog(new BackupDatabaseStatementBuilder(databaseName));
        }

        public IBackupLog Log(VariableName databaseVariableName)
        {
            return new BackupLog(new BackupDatabaseStatementBuilder(databaseVariableName));
        }

        public IBackupMasterKeyToFile MasterKey()
        {
            return new BackupMasterKey();
        }

        public IBackupServiceMasterKeyToFile ServiceMasterKey()
        {
            return new BackupServiceMasterKey();
        }
    }
}
