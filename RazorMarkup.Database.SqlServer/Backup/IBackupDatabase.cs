namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabase : IHideObjectMethods
    {
        IBackupDatabaseToAnd<IBackupDatabaseOptions> To(string logicalDeviceName);

        IBackupDatabaseToAnd<IBackupDatabaseOptions> To(VariableName logicalDeviceNameVariable);

        IBackupDatabaseTo<IBackupDatabaseOptions> To();
    }
}
