namespace RazorMarkup.Database.SqlServer.Backup
{
    internal class BackupLog : AbstractDatabaseOptions<IBackupLogOptions>,
        IBackupLog
    {
        private const bool IsMirror = false;

        public BackupLog(BackupDatabaseStatementBuilder input)
            : base(input, new BackupLogOptions(input))
        {
            input.IsBackupLogStatement = true;
        }

        public IBackupDatabaseToAnd<IBackupLogOptions> To(string logicalDeviceName)
        {
            Statement.Append(
                (IBackupLog input) => input.To((string)null),
                new RawStatementBuilder(logicalDeviceName));
            BackupDevice backupDevice = new BackupDevice()
            {
                Name = logicalDeviceName
            };
            Statement.BackupDevices.Add(backupDevice);
            return new BackupDatabaseToAnd<IBackupLogOptions>(Statement, Options, IsMirror);
        }

        public IBackupDatabaseToAnd<IBackupLogOptions> To(VariableName logicalDeviceNameVariable)
        {
            Statement.Append(
                (IBackupLog input) => input.To((VariableName)null),
                logicalDeviceNameVariable);
            BackupDevice backupDevice = new BackupDevice()
            {
                Variable = logicalDeviceNameVariable
            };
            Statement.BackupDevices.Add(backupDevice);
            return new BackupDatabaseToAnd<IBackupLogOptions>(Statement, Options, IsMirror);
        }

        public IBackupDatabaseTo<IBackupLogOptions> To()
        {
            Statement.Append((IBackupLog input) => input.To());
            return new BackupDatabaseTo<IBackupLogOptions>(Statement, Options, IsMirror);
        }
    }
}
