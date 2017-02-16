using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Create.DatabaseEncryptionKey
{
    public interface ICreateDatabaseEncryptionKeyAlgorithm : IHideObjectMethods
    {
        ICreateDatabaseEncryptionKeyEncryptionByServer Aes128();

        ICreateDatabaseEncryptionKeyEncryptionByServer Aes192();

        ICreateDatabaseEncryptionKeyEncryptionByServer Aes256();

        ICreateDatabaseEncryptionKeyEncryptionByServer TripleDes3Key();
    }
}
