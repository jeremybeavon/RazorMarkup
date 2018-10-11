namespace RazorMarkup.Database.SqlServer.Backup
{
    internal class BackupDatabaseTo<TOptions> : AbstractDatabaseOptions<TOptions>,
        IBackupDatabaseTo<TOptions>
        where TOptions : class, IBackupDatabaseOptions<TOptions>
    {
        private const bool IsMirror = false;

        public BackupDatabaseTo(BackupDatabaseStatementBuilder input, TOptions options)
            : base(input, options)
        {
        }

        public IBackupDatabaseToAnd<TOptions> To(string logicalDeviceName)
        {
            Statement.Append(
                (IBackupDatabaseTo<TOptions> input) => input.To((string)null),
                new RawStatementBuilder(logicalDeviceName));
            BackupDevice backupDevice = new BackupDevice()
            {
                Name = logicalDeviceName
            };
            Statement.BackupDevices.Add(backupDevice);
            return new BackupDatabaseToAnd<TOptions>(Statement, Options, IsMirror);
        }

        public IBackupDatabaseToAnd<TOptions> To(VariableName logicalDeviceNameVariable)
        {
            Statement.Append(
                (IBackupDatabaseTo<TOptions> input) => input.To((VariableName)null),
                logicalDeviceNameVariable);
            BackupDevice backupDevice = new BackupDevice()
            {
                Variable = logicalDeviceNameVariable
            };
            Statement.BackupDevices.Add(backupDevice);
            return new BackupDatabaseToAnd<TOptions>(Statement, Options, IsMirror);
        }

        public IBackupDatabaseToDevice<TOptions> To()
        {
            Statement.Append((IBackupDatabaseTo<TOptions> input) => input.To());
            return new BackupDatabaseToDevice<TOptions>(Statement, Options, IsMirror);
        }
    }
}
