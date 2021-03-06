﻿namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseToAnd<TOptions> : IBackupDatabaseWithMirror<TOptions>
        where TOptions : class, IBackupDatabaseOptions<TOptions>
    {
        IBackupDatabaseToAnd<TOptions> And(string logicalDeviceName);

        IBackupDatabaseToAnd<TOptions> And(VariableName logicalDeviceNameVariable);

        IBackupDatabaseToDevice<TOptions> And();
    }
}
