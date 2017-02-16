using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Create.DatabaseEncryptionKey
{
    public interface ICreateDatabaseEncryptionKeyEncryption
    {
        ISqlString Certificate(CertificateName certificateName);

        ISqlString AsymmetricKey(AsymmetricKeyName asymmetricKeyName);
    }
}
