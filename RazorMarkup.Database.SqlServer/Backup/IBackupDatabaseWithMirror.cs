namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseWithMirror<TOptions> : IBackupDatabaseWithOptions<TOptions>
        where TOptions : class, IBackupDatabaseOptions<TOptions>
    {
        IBackupDatabaseToAnd<TOptions> MirrorTo(string logicalDeviceName);

        IBackupDatabaseToAnd<TOptions> MirrorTo(VariableName logicalDeviceNameVariable);

        IBackupDatabaseToDevice<TOptions> MirrorTo();
    }
}
