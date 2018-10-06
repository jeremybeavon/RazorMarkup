using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupDatabaseStatementBuilder : AbstractStatementBuilder
    {
        public BackupDatabaseStatementBuilder(DatabaseName databaseName)
            : this()
        {
            DatabaseName = databaseName;
        }

        public BackupDatabaseStatementBuilder(VariableName databaseVariableName)
            : this()
        {
            DatabaseVariableName = databaseVariableName;
        }

        private BackupDatabaseStatementBuilder()
            : base(new ExpressionBuilder())
        {
            FileOrFileGroups = new List<BackupDevice>();
            BackupDevices = new List<BackupDevice>();
            BackupMirrors = new List<List<BackupDevice>>();
        }

        public DatabaseName DatabaseName { get; private set; }

        public VariableName DatabaseVariableName { get; private set; }

        public List<BackupDevice> FileOrFileGroups { get; private set; }

        public bool ReadWriteFileGroups { get; set; }

        public List<BackupDevice> BackupDevices { get; private set; }

        public List<List<BackupDevice>> BackupMirrors { get; set; }

        public bool HasOptions { get; set; }

        public bool Differential { get; set; }

        public bool CopyOnly { get; set; }

        public bool Compression { get; set; }

        public bool NoCompression { get; set; }

        public Expression<Func<Text>> Description { get; set; }

        public Expression<Func<Text>> Name { get; set; }

        public bool Credential { get; set; }

        public bool Encryption { get; set; }

        public bool FileSnapshot { get; set; }

        public Expression<Func<Date>> ExpireDate { get; set; }

        public Expression<Func<Integer>> RetainDays { get; set; }

        public bool NoInit { get; set; }

        public bool Init { get; set; }

        public bool NoSkip { get; set; }

        public bool Skip { get; set; }

        public bool NoFormat { get; set; }

        public bool Format { get; set; }

        public Expression<Func<Text>> MediaDescription { get; set; }

        public Expression<Func<Text>> MediaName { get; set; }

        public Expression<Func<Integer>> BlockSize { get; set; }

        public Expression<Func<Integer>> BufferCount { get; set; }

        public Expression<Func<Integer>> MaxTransferSize { get; set; }

        public bool NoChecksum { get; set; }

        public bool Checksum { get; set; }

        public bool StopOnError { get; set; }

        public bool ContinueAfterError { get; set; }

        public bool Restart { get; set; }

        public Expression<Func<Float>> Stats { get; set; }

        public bool Rewind { get; set; }

        public bool NoRewind { get; set; }

        public bool Unload { get; set; }

        public bool NoUnload { get; set; }

        public string EncryptionAlgorithm { get; set; }

        public CertificateName EncryptionCertificateName { get; set; }

        public AsymmetricKeyName EncryptionAsymmetricKeyName { get; set; }

        public override void ToSqlString(SqlBuilder sqlBuilder)
        {
            sqlBuilder.Append("BACKUP DATABASE ");
            if (DatabaseName == null)
            {
                sqlBuilder.Append(DatabaseVariableName.ToSqlString());
            }
            else
            {
                sqlBuilder.Append(DatabaseName.ToSqlString());
            }

            WriteFileOrFileGroups(sqlBuilder);
            WriteBackupDevices(sqlBuilder, BackupDevices, "TO");
            WriteBackupMirrors(sqlBuilder);
            WriteBackupOptions(sqlBuilder);
        }

        private static IDisposable WriteSeparator(SqlBuilder sqlBuilder, IDisposable indent)
        {
            if (indent == null)
            {
                indent = sqlBuilder.IncrementIndent();
            }
            else
            {
                sqlBuilder.Append(",");
                sqlBuilder.AppendIndent();
            }

            return indent;
        }

        private void WriteFileOrFileGroups(SqlBuilder sqlBuilder)
        {
            IDisposable indent = null;
            if (ReadWriteFileGroups)
            {
                sqlBuilder.AppendIndent().Append("READ_WRITE_FILEGROUPS");
                indent = sqlBuilder.IncrementIndent();
            }

            foreach (BackupDevice fileOrFileGroup in FileOrFileGroups)
            {
                indent = WriteSeparator(sqlBuilder, indent);
                fileOrFileGroup.ToSqlString(sqlBuilder);
            }

            if (indent != null)
            {
                indent.Dispose();
            }
        }

        private void WriteBackupDevices(SqlBuilder sqlBuilder, List<BackupDevice> backupDevices, string clauseName)
        {
            sqlBuilder.AppendIndent().Append(clauseName);
            sqlBuilder.Append(" ");
            IDisposable indent = null;
            foreach (BackupDevice device in backupDevices)
            {
                indent = WriteSeparator(sqlBuilder, indent);
                device.ToSqlString(sqlBuilder);
            }

            if (indent != null)
            {
                indent.Dispose();
            }
        }

        private void WriteBackupMirrors(SqlBuilder sqlBuilder)
        {
            foreach (List<BackupDevice> mirror in BackupMirrors)
            {
                WriteBackupDevices(sqlBuilder, mirror, "MIRROR TO");
            }
        }

        private void WriteBackupOptions(SqlBuilder sqlBuilder)
        {
            if (!HasOptions)
            {
                return;
            }

            IDisposable indent = null;
            sqlBuilder.AppendIndent().Append("WITH ");
            indent = WriteBooleanOption(sqlBuilder, indent, Differential, "DIFFERENTIAL");
            indent = WriteBooleanOption(sqlBuilder, indent, CopyOnly, "COPY_ONLY");
            indent = WriteBooleanOption(sqlBuilder, indent, Compression, "COMPRESSION", NoCompression, "NO_COMPRESSION");
            indent = WriteOptionExpression(sqlBuilder, indent, "DESCRIPTION", Description);
            indent = WriteOptionExpression(sqlBuilder, indent, "NAME", Name);
            indent = WriteBooleanOption(sqlBuilder, indent, Credential, "CREDENTIAL");
            indent = WriteBooleanOption(sqlBuilder, indent, Encryption, "ENCRYPTION");
            indent = WriteBooleanOption(sqlBuilder, indent, FileSnapshot, "FILE_SNAPSHOT");
            indent = WriteOptionExpression(sqlBuilder, indent, "EXPIREDATE", ExpireDate);
            indent = WriteOptionExpression(sqlBuilder, indent, "RETAINDAYS", RetainDays);
            indent = WriteBooleanOption(sqlBuilder, indent, NoInit, "NOINIT", Init, "INIT");
            indent = WriteBooleanOption(sqlBuilder, indent, NoSkip, "NOSKIP", Skip, "SKIP");
            indent = WriteBooleanOption(sqlBuilder, indent, NoFormat, "NOFORMAT", Format, "FORMAT");
            indent = WriteOptionExpression(sqlBuilder, indent, "MEDIADESCRIPTION", MediaDescription);
            indent = WriteOptionExpression(sqlBuilder, indent, "MEDIANAME", MediaName);
            indent = WriteOptionExpression(sqlBuilder, indent, "BLOCKSIZE", BlockSize);
            indent = WriteOptionExpression(sqlBuilder, indent, "BUFFERCOUNT", BufferCount);
            indent = WriteOptionExpression(sqlBuilder, indent, "MAXTRANSFERSIZE", MaxTransferSize);
            indent = WriteBooleanOption(sqlBuilder, indent, NoChecksum, "NO_CHECKSUM", Checksum, "CHECKSUM");
            indent = WriteBooleanOption(sqlBuilder, indent, StopOnError, "STOP_ON_ERROR", ContinueAfterError, "CONTINUE_AFTER_ERROR");
            indent = WriteBooleanOption(sqlBuilder, indent, Restart, "RESTART");
            indent = WriteOptionExpression(sqlBuilder, indent, "STATS", Stats);
            indent = WriteBooleanOption(sqlBuilder, indent, Rewind, "REWIND", NoRewind, "NOREWIND");
            indent = WriteBooleanOption(sqlBuilder, indent, Unload, "UNLOAD", NoUnload, "NOUNLOAD");
            indent = WriteBackupEncryptionOptions(sqlBuilder, indent);
            indent.Dispose();
        }

        private IDisposable WriteBackupEncryptionOptions(SqlBuilder sqlBuilder, IDisposable indent)
        {
            if (EncryptionAlgorithm != null)
            {
                indent = WriteSeparator(sqlBuilder, indent);
                sqlBuilder.Append("ENCRYPTION (ALGORITHM = ");
                sqlBuilder.Append(EncryptionAlgorithm);
                sqlBuilder.Append(", SERVER ");
                if (EncryptionAsymmetricKeyName == null)
                {
                    sqlBuilder.Append("CERTIFICATE = ");
                    sqlBuilder.Append(EncryptionCertificateName.ToSqlString());
                }
                else
                {
                    sqlBuilder.Append("ASSYMETRIC KEY = ");
                    sqlBuilder.Append(EncryptionAsymmetricKeyName.ToSqlString());
                }

                sqlBuilder.Append(")");
            }

            return indent;
        }

        private static IDisposable WriteBooleanOption(
            SqlBuilder sqlBuilder,
            IDisposable indent,
            bool includeOption,
            string optionName,
            bool includeOption2 = false,
            string optionName2 = null)
        {
            if (includeOption)
            {
                indent = WriteSeparator(sqlBuilder, indent);
                sqlBuilder.Append(optionName);
            }
            else if (includeOption2)
            {
                indent = WriteSeparator(sqlBuilder, indent);
                sqlBuilder.Append(optionName2);
            }

            return indent;
        }

        private static IDisposable WriteOptionExpression<T>(
            SqlBuilder sqlBuilder,
            IDisposable indent,
            string optionName,
            Expression<Func<T>> expression)
        {
            if (expression != null)
            {
                indent = WriteSeparator(sqlBuilder, indent);
                sqlBuilder.Append(optionName);
                sqlBuilder.Append(" = ");
                expression.ToExpressionBuilder().ToSqlString(sqlBuilder);
            }

            return indent;
        }
    }
}
