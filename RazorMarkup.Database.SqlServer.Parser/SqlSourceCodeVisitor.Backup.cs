using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Backup;
using RazorMarkup.Database.SqlServer.Types.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed partial class SqlSourceCodeVisitor : AbstractSqlVisitor<ISqlString>
    {
        public override void ExplicitVisit(BackupDatabaseStatement node)
        {
            IBackupDatabaseTo<IBackupDatabaseOptions> to = node.DatabaseName.Identifier == null ?
                Sql.Backup().Database(new DatabaseName(node.DatabaseName.Identifier.Value)) :
                Sql.Backup().Database(new VariableName(node.DatabaseName.Value));
            base.ExplicitVisit(node);
        }

        public override void ExplicitVisit(BackupCertificateStatement node)
        {
            IBackupCertificateWithPrivateKey withPrivateKey =
                Sql.Backup().Certificate(new CertificateName(node.Name.Value)).ToFile(node.File.Value);
            if (node.PrivateKeyPath == null)
            {
                Result = withPrivateKey;
            }
            else
            {
                IBackupCertificatePrivateKeyDecryption withDecryption = withPrivateKey.WithPrivateKey()
                    .File(node.PrivateKeyPath.Value)
                    .AndEncryptionByPassword(node.EncryptionPassword.Value);
                Result = node.DecryptionPassword == null ?
                    (ISqlString)withDecryption :
                    withDecryption.AndDecryptionByPassword(node.DecryptionPassword.Value);
            }
        }

        public override void ExplicitVisit(BackupMasterKeyStatement node)
        {
            Result = Sql.Backup().MasterKey().ToFile(node.File.Value).EncryptionByPassword(node.Password.Value);
        }

        public override void ExplicitVisit(BackupServiceMasterKeyStatement node)
        {
            Result = Sql.Backup().ServiceMasterKey().ToFile(node.File.Value).EncryptionByPassword(node.Password.Value);
        }

        public override void ExplicitVisit(BackupTransactionLogStatement node)
        {
            IBackupDatabaseTo<IBackupLogOptions> to = node.DatabaseName.Identifier == null ?
                Sql.Backup().Log(new DatabaseName(node.DatabaseName.Identifier.Value)) :
                Sql.Backup().Log(new VariableName(node.DatabaseName.Value));

        }

        private static ISqlString ProcesBackupStatement<TOptions>(
            BackupStatement node,
            IBackupDatabaseTo<TOptions> to)
            where TOptions : class, IBackupDatabaseOptions<TOptions>
        {
            IBackupDatabaseWithMirror<TOptions> mirror = ProcessBackupDeviceInfo(
                node.Devices,
                to,
                (input, name) => input.To(name),
                (input, variable) => input.To(variable),
                input => input.To());
            foreach (MirrorToClause mirrorToClause in node.MirrorToClauses)
            {
                mirror = ProcessBackupDeviceInfo(
                    mirrorToClause.Devices,
                    mirror,
                    (input, name) => input.MirrorTo(name),
                    (input, variable) => input.MirrorTo(variable),
                    input => input.MirrorTo());
            }

            return node.Options.Count == 0 ? mirror : ProcessBackupOptions(node, mirror);
        }
        
        private static IBackupDatabaseToAnd<TOptions> ProcessBackupDeviceInfo<TInput, TOptions>(
            IList<DeviceInfo> devices,
            TInput input,
            Func<TInput, string, IBackupDatabaseToAnd<TOptions>> nameFunc,
            Func<TInput, VariableName, IBackupDatabaseToAnd<TOptions>> variableFunc,
            Func<TInput, IBackupDatabaseToDevice<TOptions>> deviceFunc)
            where TOptions : class, IBackupDatabaseOptions<TOptions>
        {
            IBackupDatabaseToAnd<TOptions> toAnd =
                ProcessBackupDeviceInfo(devices[0], input, nameFunc, variableFunc, deviceFunc);
            foreach (DeviceInfo device in devices.Skip(1))
            {
                toAnd = ProcessBackupDeviceInfo(
                    device,
                    toAnd,
                    (toAndInput, name) => toAndInput.And(name),
                    (toAndInput, variable) => toAndInput.And(variable),
                    toAndInput => toAndInput.And());
            }
            
            return toAnd;
        }

        private static IBackupDatabaseToAnd<TOptions> ProcessBackupDeviceInfo<TInput, TOptions>(
            DeviceInfo device,
            TInput input,
            Func<TInput, string, IBackupDatabaseToAnd<TOptions>> nameFunc,
            Func<TInput, VariableName, IBackupDatabaseToAnd<TOptions>> variableFunc,
            Func<TInput, IBackupDatabaseToDevice<TOptions>> deviceFunc)
            where TOptions : class, IBackupDatabaseOptions<TOptions>
        {
            IBackupDatabaseToAnd<TOptions> toAnd = null;
            switch (device.DeviceType)
            {
                case DeviceType.None:
                    toAnd = device.LogicalDevice.Identifier == null ?
                        variableFunc(input, new VariableName(device.LogicalDevice.Value)) :
                        nameFunc(input, device.LogicalDevice.Identifier.Value);
                    break;
                case DeviceType.Disk:
                    break;
            }

            return toAnd;
        }

        private static ISqlString ProcessBackupOptions<TOptions>(
            BackupStatement node,
            IBackupDatabaseWithOptions<TOptions> options)
            where TOptions : class, IBackupDatabaseOptions<TOptions>
        {
            IBackupDatabaseOptionsAnd<TOptions> and = null;
            TOptions optionsFunc() => and == null ? options.With() : and.And();
            foreach (BackupOption option in node.Options)
            {
                switch (option.OptionKind)
                {
                    case BackupOptionKind.BlockSize:
                        and = optionsFunc().BlockSize(option.Value.ToExpression<Integer>());
                        break;
                    case BackupOptionKind.BufferCount:
                        and = optionsFunc().BufferCount(option.Value.ToExpression<Integer>());
                        break;
                    case BackupOptionKind.Checksum:
                        and = optionsFunc().Checksum();
                        break;
                    case BackupOptionKind.Compression:
                        and = optionsFunc().Compression();
                        break;
                    case BackupOptionKind.ContinueAfterError:
                        and = optionsFunc().ContinueAfterError();
                        break;
                    case BackupOptionKind.CopyOnly:
                        and = optionsFunc().CopyOnly();
                        break;
                    case BackupOptionKind.Description:
                        and = optionsFunc().Description(option.Value.ToExpression<Text>());
                        break;
                    case BackupOptionKind.Differential:
                        and = (IBackupDatabaseOptionsAnd<TOptions>)((IBackupDatabaseOptions)optionsFunc()).Differential();
                        break;
                    case BackupOptionKind.Encryption:
                        and = optionsFunc().Encryption();
                        break;
                    case BackupOptionKind.ExpireDate:
                        and = optionsFunc().ExpireDate(option.Value.ToExpression<Date>());
                        break;
                    case BackupOptionKind.Format:
                        and = optionsFunc().Format();
                        break;
                    case BackupOptionKind.Init:
                        and = optionsFunc().Init();
                        break;
                    case BackupOptionKind.MaxTransferSize:
                        and = optionsFunc().MaxTransferSize(option.Value.ToExpression<Integer>());
                        break;
                    case BackupOptionKind.MediaDescription:
                        and = optionsFunc().MediaDescription(option.Value.ToExpression<Text>());
                        break;
                    case BackupOptionKind.Name:
                        and = optionsFunc().Name(option.Value.ToExpression<Text>());
                        break;
                    case BackupOptionKind.NoChecksum:
                        and = optionsFunc().NoChecksum();
                        break;
                    case BackupOptionKind.NoCompression:
                        and = optionsFunc().NoCompression();
                        break;
                    case BackupOptionKind.NoFormat:
                        and = optionsFunc().NoFormat();
                        break;
                    case BackupOptionKind.NoInit:
                        and = optionsFunc().NoInit();
                        break;
                    
                }
            }

            return and;
        }
    }
}
