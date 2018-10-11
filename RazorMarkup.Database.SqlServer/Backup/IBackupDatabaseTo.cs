﻿namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseTo<TOptions> : IHideObjectMethods
    {
        IBackupDatabaseToAnd<TOptions> Disk(string physicalDeviceName);

        IBackupDatabaseToAnd<TOptions> Disk(VariableName physicalDeviceNameVariable);

        IBackupDatabaseToAnd<TOptions> Tape(string physicalDeviceName);

        IBackupDatabaseToAnd<TOptions> Tape(VariableName physicalDeviceNameVariable);

        IBackupDatabaseToAnd<TOptions> Url(string physicalDeviceName);

        IBackupDatabaseToAnd<TOptions> Url(VariableName physicalDeviceNameVariable);
    }
}
