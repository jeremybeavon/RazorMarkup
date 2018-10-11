namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupLog : IHideObjectMethods
    {
        IBackupDatabaseToAnd<IBackupLogOptions> To(string logicalDeviceName);

        IBackupDatabaseToAnd<IBackupLogOptions> To(VariableName logicalDeviceNameVariable);

        IBackupDatabaseTo<IBackupLogOptions> To();
    }
}
