using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupLogOptions : BackupDatabaseOptions<IBackupLogOptions>,
        IBackupLogOptions
    {
        public BackupLogOptions(BackupDatabaseStatementBuilder statement)
            : base(statement, null)
        {
            Options = this;
        }
        
        public IBackupDatabaseOptionsAnd<IBackupLogOptions> NoRecovery()
        {
            Statement.Append((IBackupLogOptions input) => input.NoRecovery());
            Statement.NoRecovery = true;
            return new BackupDatabaseOptionsAnd<IBackupLogOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<IBackupLogOptions> NoTruncate()
        {
            Statement.Append((IBackupLogOptions input) => input.NoTruncate());
            Statement.NoTruncate = true;
            return new BackupDatabaseOptionsAnd<IBackupLogOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<IBackupLogOptions> Standby(Expression<Func<Text>> undoFileName)
        {
            Statement.Append((IBackupLogOptions input) => input.Standby(null), undoFileName);
            Statement.Standby = undoFileName;
            return new BackupDatabaseOptionsAnd<IBackupLogOptions>(Statement, Options);
        }
    }
}
