using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Backup
{
    internal sealed class BackupStatements : IBackupStatements
    {
        public IBackupCertificateToFile Certificate(CertificateName certificateName)
        {
            return new BackupCertificateToFile(certificateName);
        }

        public IBackupDatabase Database(DatabaseName databaseName)
        {
            throw new NotImplementedException();
        }

        public IBackupMasterKeyToFile MasterKey()
        {
            return new BackupMasterKey();
        }

        public IBackupServiceMasterKeyToFile ServiceMasterKey()
        {
            return new BackupServiceMasterKey();
        }
    }
}
