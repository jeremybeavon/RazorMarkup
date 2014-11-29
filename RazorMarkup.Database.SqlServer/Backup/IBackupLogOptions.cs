using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupLogOptions : IBackupDatabaseOptions<IBackupLogOptions>
    {
        IBackupDatabaseOptionsAnd<IBackupLogOptions> NoRecovery();

        IBackupDatabaseOptionsAnd<IBackupLogOptions> Standby(Expression<Func<Text>> undoFileName);

        IBackupDatabaseOptionsAnd<IBackupLogOptions> NoTruncate();
    }
}
