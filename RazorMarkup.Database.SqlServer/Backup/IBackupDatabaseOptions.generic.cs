using System;
using System.Linq.Expressions;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Backup
{
    public interface IBackupDatabaseOptions<TOptions> : IHideObjectMethods
        where TOptions : class, IBackupDatabaseOptions<TOptions>
    {
        IBackupDatabaseOptionsAnd<TOptions> CopyOnly();

        IBackupDatabaseOptionsAnd<TOptions> Compression();

        IBackupDatabaseOptionsAnd<TOptions> NoCompression();

        IBackupDatabaseOptionsAnd<TOptions> Description(Expression<Func<Text>> text);

        IBackupDatabaseOptionsAnd<TOptions> Name(Expression<Func<Text>> backupSetName);

        IBackupDatabaseOptionsAnd<TOptions> ExpireDate(Expression<Func<Date>> expiryDate);

        IBackupDatabaseOptionsAnd<TOptions> RetainDays(Expression<Func<Integer>> retainDays);

        IBackupDatabaseOptionsAnd<TOptions> NoInit();

        IBackupDatabaseOptionsAnd<TOptions> Init();

        IBackupDatabaseOptionsAnd<TOptions> NoSkip();

        IBackupDatabaseOptionsAnd<TOptions> Skip();

        IBackupDatabaseOptionsAnd<TOptions> NoFormat();

        IBackupDatabaseOptionsAnd<TOptions> Format();

        IBackupDatabaseOptionsAnd<TOptions> MediaDescription(Expression<Func<Text>> mediaDescription);

        IBackupDatabaseOptionsAnd<TOptions> BlockSize(Expression<Func<Integer>> blockSize);

        IBackupDatabaseOptionsAnd<TOptions> BufferCount(Expression<Func<Integer>> bufferCount);

        IBackupDatabaseOptionsAnd<TOptions> MaxTransferSize(Expression<Func<Integer>> maxTransferSize);

        IBackupDatabaseOptionsAnd<TOptions> NoChecksum();

        IBackupDatabaseOptionsAnd<TOptions> Checksum();

        IBackupDatabaseOptionsAnd<TOptions> StopOnError();

        IBackupDatabaseOptionsAnd<TOptions> ContinueAfterError();

        IBackupDatabaseOptionsAnd<TOptions> Restart();

        IBackupDatabaseOptionsAnd<TOptions> Stats(Expression<Func<Float>> percentage);

        IBackupDatabaseOptionsAnd<TOptions> Rewind();

        IBackupDatabaseOptionsAnd<TOptions> NoRewind();

        IBackupDatabaseOptionsAnd<TOptions> Unload();

        IBackupDatabaseOptionsAnd<TOptions> NoUnload();

        IBackupDatabaseEncryptionWithAlgorithm<TOptions> Encryption();
    }
}
