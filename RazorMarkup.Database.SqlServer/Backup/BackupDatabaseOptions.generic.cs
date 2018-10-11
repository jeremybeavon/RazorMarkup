using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Backup
{
    internal class BackupDatabaseOptions<TOptions> : AbstractDatabaseOptions<TOptions>,
        IBackupDatabaseOptions<TOptions>
    {
        public BackupDatabaseOptions(BackupDatabaseStatementBuilder statement, TOptions options)
            : base(statement, options)
        {
        }

        public IBackupDatabaseOptionsAnd<TOptions> BlockSize(Expression<Func<Integer>> blockSize)
        {
            Statement.Append(
                (IBackupDatabaseOptions<TOptions> input) => input.BlockSize(null),
                blockSize);
            Statement.BlockSize = blockSize;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> BufferCount(Expression<Func<Integer>> bufferCount)
        {
            Statement.Append(
                (IBackupDatabaseOptions<TOptions> input) => input.BufferCount(null),
                bufferCount);
            Statement.BufferCount = bufferCount;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> Checksum()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.Checksum());
            Statement.Checksum = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> Compression()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.Compression());
            Statement.Compression = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> ContinueAfterError()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.ContinueAfterError());
            Statement.ContinueAfterError = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> CopyOnly()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.CopyOnly());
            Statement.CopyOnly = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> Description(Expression<Func<Text>> text)
        {
            Statement.Append(
                (IBackupDatabaseOptions<TOptions> input) => input.Description(null),
                text);
            Statement.Description = text;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseEncryptionWithAlgorithm<TOptions> Encryption()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.Encryption());
            return new BackupDatabaseEncryptionWithAlgorithm<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> ExpireDate(Expression<Func<Date>> expiryDate)
        {
            Statement.Append(
                (IBackupDatabaseOptions<TOptions> input) => input.ExpireDate(null),
                expiryDate);
            Statement.ExpireDate = expiryDate;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> Format()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.Format());
            Statement.Format = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> Init()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.Init());
            Statement.Init = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> MaxTransferSize(Expression<Func<Integer>> maxTransferSize)
        {
            Statement.Append(
                (IBackupDatabaseOptions<TOptions> input) => input.MaxTransferSize(null),
                maxTransferSize);
            Statement.BlockSize = maxTransferSize;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> MediaDescription(Expression<Func<Text>> mediaDescription)
        {
            Statement.Append(
                (IBackupDatabaseOptions<TOptions> input) => input.MediaDescription(null),
                mediaDescription);
            Statement.MediaDescription = mediaDescription;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> Name(Expression<Func<Text>> backupSetName)
        {
            Statement.Append(
                (IBackupDatabaseOptions<TOptions> input) => input.Name(null),
                backupSetName);
            Statement.Name = backupSetName;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> NoChecksum()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.NoChecksum());
            Statement.NoChecksum = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> NoCompression()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.NoChecksum());
            Statement.NoChecksum = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> NoFormat()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.NoFormat());
            Statement.NoFormat = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> NoInit()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.NoInit());
            Statement.NoInit = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> NoRewind()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.NoRewind());
            Statement.NoRewind = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> NoSkip()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.NoSkip());
            Statement.NoSkip = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> NoUnload()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.NoUnload());
            Statement.NoUnload = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> Restart()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.Restart());
            Statement.Restart = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> RetainDays(Expression<Func<Integer>> retainDays)
        {
            Statement.Append(
                (IBackupDatabaseOptions<TOptions> input) => input.RetainDays(null),
                retainDays);
            Statement.RetainDays = retainDays;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> Rewind()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.Rewind());
            Statement.Rewind = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }
        
        public IBackupDatabaseOptionsAnd<TOptions> Skip()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.Skip());
            Statement.Skip = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> Stats(Expression<Func<Float>> percentage)
        {
            Statement.Append(
                (IBackupDatabaseOptions<TOptions> input) => input.Stats(null),
                percentage);
            Statement.Stats = percentage;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> StopOnError()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.StopOnError());
            Statement.StopOnError = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }

        public IBackupDatabaseOptionsAnd<TOptions> Unload()
        {
            Statement.Append((IBackupDatabaseOptions<TOptions> input) => input.Unload());
            Statement.Unload = true;
            return new BackupDatabaseOptionsAnd<TOptions>(Statement, Options);
        }
    }
}
