using System.Collections.Generic;

namespace RazorMarkup.Database.SqlServer.Backup
{
    internal class BackupDatabaseWithMirror<TOptions> : BackupDatabaseWithOptions<TOptions>,
        IBackupDatabaseWithMirror<TOptions>
    {
        private const bool IsMirror = true;

        public BackupDatabaseWithMirror(BackupDatabaseStatementBuilder input, TOptions options)
            : base(input, options)
        {
        }

        public IBackupDatabaseToAnd<TOptions> MirrorTo(string logicalDeviceName)
        {
            Statement.Append(
                (IBackupDatabaseWithMirror<TOptions> input) => input.MirrorTo((string)null),
                new RawStatementBuilder(logicalDeviceName));
            BackupDevice backupDevice = new BackupDevice()
            {
                Name = logicalDeviceName
            };
            Statement.BackupMirrors.Add(new List<BackupDevice>(new[] { backupDevice }));
            return new BackupDatabaseToAnd<TOptions>(Statement, Options, IsMirror);
        }

        public IBackupDatabaseToAnd<TOptions> MirrorTo(VariableName logicalDeviceNameVariable)
        {
            Statement.Append(
                (IBackupDatabaseToAnd<TOptions> input) => input.And((VariableName)null),
                logicalDeviceNameVariable);
            BackupDevice backupDevice = new BackupDevice()
            {
                Variable = logicalDeviceNameVariable
            };
            Statement.BackupMirrors.Add(new List<BackupDevice>(new[] { backupDevice }));
            return new BackupDatabaseToAnd<TOptions>(Statement, Options, IsMirror);
        }

        public IBackupDatabaseTo<TOptions> MirrorTo()
        {
            Statement.Append((IBackupDatabaseWithMirror<TOptions> input) => input.MirrorTo());
            Statement.BackupMirrors.Add(new List<BackupDevice>());
            return new BackupDatabaseTo<TOptions>(Statement, Options, IsMirror);
        }
    }
}
