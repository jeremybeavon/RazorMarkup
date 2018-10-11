namespace RazorMarkup.Database.SqlServer.Backup
{
    internal class BackupDatabase : AbstractDatabaseOptions<IBackupDatabaseOptions>,
        IBackupDatabase
    {
        private const bool IsMirror = false;

        public BackupDatabase(BackupDatabaseStatementBuilder input)
            : base(input, new BackupDatabaseOptions(input))
        {
        }

        public IBackupDatabaseToAnd<IBackupDatabaseOptions> To(string logicalDeviceName)
        {
            Statement.Append(
                (IBackupDatabase input) => input.To((string)null),
                new RawStatementBuilder(logicalDeviceName));
            BackupDevice backupDevice = new BackupDevice()
            {
                Name = logicalDeviceName
            };
            Statement.BackupDevices.Add(backupDevice);
            return new BackupDatabaseToAnd<IBackupDatabaseOptions>(Statement, Options, IsMirror);
        }

        public IBackupDatabaseToAnd<IBackupDatabaseOptions> To(VariableName logicalDeviceNameVariable)
        {
            Statement.Append(
                (IBackupDatabase input) => input.To((VariableName)null),
                logicalDeviceNameVariable);
            BackupDevice backupDevice = new BackupDevice()
            {
                Variable = logicalDeviceNameVariable
            };
            Statement.BackupDevices.Add(backupDevice);
            return new BackupDatabaseToAnd<IBackupDatabaseOptions>(Statement, Options, IsMirror);
        }

        public IBackupDatabaseTo<IBackupDatabaseOptions> To()
        {
            Statement.Append((IBackupDatabase input) => input.To());
            return new BackupDatabaseTo<IBackupDatabaseOptions>(Statement, Options, IsMirror);
        }
    }
}
