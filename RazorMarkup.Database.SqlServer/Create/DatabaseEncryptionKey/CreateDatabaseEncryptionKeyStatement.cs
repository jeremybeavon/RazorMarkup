using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Database.SqlServer.Create.DatabaseEncryptionKey
{
    internal sealed class CreateDatabaseEncryptionKeyStatement : SqlBuilder,
        ICreateDatabaseEncryptionKeyStatement,
        ICreateDatabaseEncryptionKeyAlgorithm,
        ICreateDatabaseEncryptionKeyEncryptionByServer,
        ICreateDatabaseEncryptionKeyEncryption
    {
        public CreateDatabaseEncryptionKeyStatement()
            : base("CREATE DATABASE ENCRYPTION KEY", () => Sql.Create().DatabaseEncryptionKey())
        {
        }

        public ICreateDatabaseEncryptionKeyEncryptionByServer Aes128()
        {
            Append("AES_128");
            Append((ICreateDatabaseEncryptionKeyAlgorithm input) => input.Aes128());
            return this;
        }

        public ICreateDatabaseEncryptionKeyEncryptionByServer Aes192()
        {
            Append("AES_192");
            Append((ICreateDatabaseEncryptionKeyAlgorithm input) => input.Aes192());
            return this;
        }

        public ICreateDatabaseEncryptionKeyEncryptionByServer Aes256()
        {
            Append("AES_256");
            Append((ICreateDatabaseEncryptionKeyAlgorithm input) => input.Aes256());
            return this;
        }

        public ISqlString AsymmetricKey(AsymmetricKeyName asymmetricKeyName)
        {
            Append("ASYMMETRIC KEY ");
            Append(asymmetricKeyName.ToSqlString());
            Append((ICreateDatabaseEncryptionKeyEncryption input) => input.AsymmetricKey(null), asymmetricKeyName);
            return this;
        }

        public ISqlString Certificate(CertificateName certificateName)
        {
            Append("CERTIFICATE ");
            Append(certificateName.ToSqlString());
            Append((ICreateDatabaseEncryptionKeyEncryption input) => input.Certificate(null), certificateName);
            return this;
        }

        public ICreateDatabaseEncryptionKeyEncryption EncryptionByServer()
        {
            AppendIndent();
            Append("ENCRYPTION BY SERVER ");
            Append((ICreateDatabaseEncryptionKeyEncryptionByServer input) => input.EncryptionByServer());
            return this;
        }

        public ICreateDatabaseEncryptionKeyEncryptionByServer TripleDes3Key()
        {
            Append("TRIPLE_DES_3KEY");
            Append((ICreateDatabaseEncryptionKeyAlgorithm input) => input.TripleDes3Key());
            return this;
        }

        public ICreateDatabaseEncryptionKeyAlgorithm WithAlgorithm()
        {
            AppendIndent();
            Append("WITH ALGORITHM = ");
            Append((ICreateDatabaseEncryptionKeyStatement input) => input.WithAlgorithm());
            return this;
        }
    }
}
