namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseTo<TOptions> : IHideObjectMethods
        where TOptions : class, IBackupDatabaseOptions<TOptions>
    {
        IBackupDatabaseToAnd<TOptions> To(string logicalDeviceName);

        IBackupDatabaseToAnd<TOptions> To(VariableName logicalDeviceNameVariable);

        IBackupDatabaseToDevice<TOptions> To();
    }
}
