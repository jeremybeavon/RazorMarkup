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

        public IBackupDatabaseOptionsAnd<IBackupDatabaseOptions> Differential()
        {
            Statement.Append((IBackupDatabaseOptions input) => input.Differential());
            Statement.Differential = true;
            return new BackupDatabaseOptionsAnd<IBackupDatabaseOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<IBackupLogOptions> NoRecovery()
        {
            
            throw new NotImplementedException();
        }

        public IBackupDatabaseOptionsAnd<IBackupLogOptions> NoTruncate()
        {
            throw new NotImplementedException();
        }

        public IBackupDatabaseOptionsAnd<IBackupLogOptions> Standby(Expression<Func<Text>> undoFileName)
        {
            throw new NotImplementedException();
        }
    }
}
