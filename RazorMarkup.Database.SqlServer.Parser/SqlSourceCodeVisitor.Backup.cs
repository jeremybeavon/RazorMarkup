using Microsoft.SqlServer.TransactSql.ScriptDom;
using RazorMarkup.Database.SqlServer.Backup;

namespace RazorMarkup.Database.SqlServer.Parser
{
    internal sealed partial class SqlSourceCodeVisitor : AbstractSqlVisitor<ISqlString>
    {
        public override void ExplicitVisit(BackupMasterKeyStatement node)
        {
            Result = Sql.Backup().MasterKey().ToFile(node.File.Value).EncryptionByPassword(node.Password.Value);
        }

        public override void ExplicitVisit(BackupServiceMasterKeyStatement node)
        {
            Result = Sql.Backup().ServiceMasterKey().ToFile(node.File.Value).EncryptionByPassword(node.Password.Value);
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
    }
}
