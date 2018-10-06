namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseToAnd : IBackupDatabaseWithMirror
    {
        IBackupDatabaseToAnd And(string logicalDeviceName);

        IBackupDatabaseToAnd And(VariableName logicalDeviceNameVariable);

        IBackupDatabaseTo And();
    }
}
