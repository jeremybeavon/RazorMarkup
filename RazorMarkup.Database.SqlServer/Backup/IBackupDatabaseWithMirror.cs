namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseWithMirror<TOptions> : IBackupDatabaseWithOptions<TOptions>
    {
        IBackupDatabaseToAnd<TOptions> MirrorTo(string logicalDeviceName);

        IBackupDatabaseToAnd<TOptions> MirrorTo(VariableName logicalDeviceNameVariable);

        IBackupDatabaseTo<TOptions> MirrorTo();
    }
}
