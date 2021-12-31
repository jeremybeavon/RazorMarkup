using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Backup
{
    internal class BackupDatabaseToAnd<TOptions> : BackupDatabaseWithMirror<TOptions>,
        IBackupDatabaseToAnd<TOptions>
        where TOptions : class, IBackupDatabaseOptions<TOptions>
    {
        private readonly bool isMirror;

        public BackupDatabaseToAnd(BackupDatabaseStatementBuilder input, TOptions options, bool isMirror)
            : base(input, options)
        {
            this.isMirror = isMirror;
        }

        private List<BackupDevice> BackupDevices =>
            isMirror ? Statement.BackupMirrors.Last() : Statement.BackupDevices;

        public IBackupDatabaseToAnd<TOptions> And(string logicalDeviceName)
        {
            Statement.Append(
                (IBackupDatabaseToAnd<TOptions> input) => input.And((string)null),
                new RawStatementBuilder(logicalDeviceName));
            BackupDevice backupDevice = new()
            {
                Name = logicalDeviceName
            };
            Statement.BackupDevices.Add(backupDevice);
            return this;
        }

        public IBackupDatabaseToAnd<TOptions> And(VariableName logicalDeviceNameVariable)
        {
            Statement.Append(
                (IBackupDatabaseToAnd<TOptions> input) => input.And((VariableName)null),
                logicalDeviceNameVariable);
            BackupDevice backupDevice = new()
            {
                Variable = logicalDeviceNameVariable
            };
            Statement.BackupDevices.Add(backupDevice);
            return this;
        }

        public IBackupDatabaseToDevice<TOptions> And()
        {
            Statement.Append((IBackupDatabaseToAnd<TOptions> input) => input.And());
            return new BackupDatabaseToDevice<TOptions>(Statement, Options, isMirror: false);
        }
    }
}
