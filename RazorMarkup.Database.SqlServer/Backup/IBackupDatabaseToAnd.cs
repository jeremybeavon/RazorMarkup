namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseToAnd<TOptions> : IBackupDatabaseWithMirror<TOptions>
    {
        IBackupDatabaseToAnd<TOptions> And(string logicalDeviceName);

        IBackupDatabaseToAnd<TOptions> And(VariableName logicalDeviceNameVariable);

        IBackupDatabaseTo<TOptions> And();
    }
}
