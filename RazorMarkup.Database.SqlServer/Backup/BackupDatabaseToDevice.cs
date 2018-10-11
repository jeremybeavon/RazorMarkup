using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Backup
{
    internal class BackupDatabaseToDevice<TOptions> : AbstractDatabaseOptions<TOptions>,
        IBackupDatabaseToDevice<TOptions>
        where TOptions : class, IBackupDatabaseOptions<TOptions>
    {
        private readonly bool isMirror;

        public BackupDatabaseToDevice(BackupDatabaseStatementBuilder input, TOptions options, bool isMirror)
            : base(input, options)
        {
            this.isMirror = isMirror;
        }

        private List<BackupDevice> BackupDevices =>
            isMirror ? Statement.BackupMirrors.Last() : Statement.BackupDevices;
        
        public IBackupDatabaseToAnd<TOptions> Disk(string physicalDeviceName)
        {
            Statement.Append(
                (IBackupDatabaseToDevice<TOptions> input) => input.Disk((string)null),
                new RawStatementBuilder(physicalDeviceName));
            BackupDevice backupDevice = new BackupDevice()
            {
                DeviceType = "DISK",
                Name = physicalDeviceName,
                IncludeQuotes = true
            };
            BackupDevices.Add(backupDevice);
            return new BackupDatabaseToAnd<TOptions>(Statement, Options, isMirror);
        }

        public IBackupDatabaseToAnd<TOptions> Disk(VariableName physicalDeviceNameVariable)
        {
            Statement.Append(
                (IBackupDatabaseToDevice<TOptions> input) => input.Disk((VariableName)null),
                physicalDeviceNameVariable);
            BackupDevice backupDevice = new BackupDevice()
            {
                DeviceType = "DISK",
                Variable = physicalDeviceNameVariable,
                IncludeQuotes = true
            };
            BackupDevices.Add(backupDevice);
            return new BackupDatabaseToAnd<TOptions>(Statement, Options, isMirror);
        }

        public IBackupDatabaseToAnd<TOptions> Tape(string physicalDeviceName)
        {
            Statement.Append(
                (IBackupDatabaseToDevice<TOptions> input) => input.Tape((string)null),
                new RawStatementBuilder(physicalDeviceName));
            BackupDevice backupDevice = new BackupDevice()
            {
                DeviceType = "TAPE",
                Name = physicalDeviceName,
                IncludeQuotes = true
            };
            BackupDevices.Add(backupDevice);
            return new BackupDatabaseToAnd<TOptions>(Statement, Options, isMirror);
        }

        public IBackupDatabaseToAnd<TOptions> Tape(VariableName physicalDeviceNameVariable)
        {
            Statement.Append(
                (IBackupDatabaseToDevice<TOptions> input) => input.Tape((VariableName)null),
                physicalDeviceNameVariable);
            BackupDevice backupDevice = new BackupDevice()
            {
                DeviceType = "TAPE",
                Variable = physicalDeviceNameVariable,
                IncludeQuotes = true
            };
            BackupDevices.Add(backupDevice);
            return new BackupDatabaseToAnd<TOptions>(Statement, Options, isMirror);
        }

        public IBackupDatabaseToAnd<TOptions> Url(string physicalDeviceName)
        {
            Statement.Append(
                (IBackupDatabaseToDevice<TOptions> input) => input.Url((string)null),
                new RawStatementBuilder(physicalDeviceName));
            BackupDevice backupDevice = new BackupDevice()
            {
                DeviceType = "URL",
                Name = physicalDeviceName,
                IncludeQuotes = true
            };
            BackupDevices.Add(backupDevice);
            return new BackupDatabaseToAnd<TOptions>(Statement, Options, isMirror);
        }

        public IBackupDatabaseToAnd<TOptions> Url(VariableName physicalDeviceNameVariable)
        {
            Statement.Append(
                (IBackupDatabaseToDevice<TOptions> input) => input.Url((VariableName)null),
                physicalDeviceNameVariable);
            BackupDevice backupDevice = new BackupDevice()
            {
                DeviceType = "URL",
                Variable = physicalDeviceNameVariable,
                IncludeQuotes = true
            };
            BackupDevices.Add(backupDevice);
            return new BackupDatabaseToAnd<TOptions>(Statement, Options, isMirror);
        }
    }
}
