namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabase : IHideObjectMethods
    {
        IBackupDatabaseToAnd To(string logicalDeviceName);

        IBackupDatabaseToAnd To(VariableName logicalDeviceNameVariable);

        IBackupDatabaseTo To();
    }
}
