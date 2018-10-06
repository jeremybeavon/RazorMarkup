namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseTo : IHideObjectMethods
    {
        IBackupDatabaseToAnd Disk(string physicalDeviceName);

        IBackupDatabaseToAnd Disk(VariableName physicalDeviceNameVariable);

        IBackupDatabaseToAnd Tape(string physicalDeviceName);

        IBackupDatabaseToAnd Tape(VariableName physicalDeviceNameVariable);

        IBackupDatabaseToAnd Url(string physicalDeviceName);

        IBackupDatabaseToAnd Url(VariableName physicalDeviceNameVariable);
    }
}
