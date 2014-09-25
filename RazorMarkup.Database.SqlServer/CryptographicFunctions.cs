using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer
{
    public static class CryptographicFunctions
    {
        public static SqlInt AsymmetricKeyId(AsymmetricKeyName asymmetricKeyName)
        {
            throw new NotInExpressionException();
        }

        public static SqlVariant AsymmetricKeyProperty(SqlInt asymmetricKeyId, Text algorithmOrSid)
        {
            throw new NotInExpressionException();
        }

        public static SqlVariant CertificateProperty(SqlInt certificateId, Text propertyName) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlInt CertificateId(CertificateName certificateName)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt CertificateId(Text certificateName)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary CryptographicRandom(SqlInt length)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary CryptographicRandom(SqlInt length, SqlVarbinary seed)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary DecryptByAsymmetricKey(SqlInt asymmetricKeyId, Text cipherText)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary DecryptByAsymmetricKey(
            SqlInt asymmetricKeyId,
            Text cipherText,
            Text asymmetricKeyPassword)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary DecryptByCertificate(SqlInt certificateId, Text cipherText)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary DecryptByCertificate(SqlInt certificateId, Text cipherText, Text certificatePassword)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary DecryptByKey(Text cipherText)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary DecryptByKey(
            Text cipherText,
            SqlInt addAuthenticator,
            SqlSysname authenticator)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary DecryptByKeyUsingAsymmetricKey(
            SqlInt asymmetricKeyId,
            SqlVarchar asymmetricKeyPassword,
            Text cipherText)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary DecryptByKeyUsingAsymmetricKey(
            SqlInt asymmetricKeyId,
            SqlVarchar asymmetricKeyPassword,
            Text cipherText,
            SqlInt addAuthenticator)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary DecryptByKeyUsingAsymmetricKey(
            SqlInt asymmetricKeyId,
            SqlVarchar asymmetricKeyPassword,
            Text cipherText,
            SqlInt addAuthenticator,
            SqlSysname authenticator)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary DecryptByKeyUsingCertificate(
            SqlInt certificateId,
            SqlVarchar certificatePassword,
            Text cipherText)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary DecryptByKeyUsingCertificate(
            SqlInt certificateId,
            SqlVarchar certificatePassword,
            Text cipherText,
            SqlInt addAuthenticator)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary DecryptByKeyUsingCertificate(
            SqlInt certificateId,
            SqlVarchar certificatePassword,
            Text cipherText,
            SqlInt addAuthenticator,
            SqlSysname authenticator)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary DecryptByPassPhrase(
            Text passPhrase,
            Text cipherText)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary DecryptByPassPhrase(
            Text passPhrase,
            Text cipherText,
            SqlInt addAuthenticator,
            SqlSysname authenticator)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary EncryptByAsymmetricKey(
            SqlInt asymmetricKeyId,
            Text plainText)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary EncryptByCertificate(
            SqlInt certificateId,
            Text clearText)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary EncryptByKey(
            SqlUniqueIdentifier keyGuid,
            Text clearText)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary EncryptByKey(
            SqlUniqueIdentifier keyGuid,
            Text clearText,
            SqlInt addAuthenticator,
            SqlSysname authenticator)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary EncryptByPassPhrase(
            Text passPhrase,
            Text clearText)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary EncryptByPassPhrase(
            Text passPhrase,
            Text clearText,
            SqlInt addAuthenticator,
            SqlSysname authenticator)
        {
            throw new NotInExpressionException();
        }

        public static SqlBit IsObjectSigned(
            Text securableClass,
            SqlInt objectId,
            SqlSysname @class,
            SqlVarbinary thumbprint)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarbinary HashBytes(Text algorithm, Text input) // Enum
        {
            throw new NotInExpressionException();
        }

        public static SqlUniqueIdentifier KeyGuid(Text keyName)
        {
            throw new NotInExpressionException();
        }

        public static SqlInt KeyId(Text keyName)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar KeyName(SqlVarbinary cipherText)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar KeyName(SqlUniqueIdentifier keyGuid)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar SignByAsymmetricKey(
            SqlInt asymmetricKeyId,
            Text plainText)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar SignByAsymmetricKey(
            SqlInt asymmetricKeyId,
            Text plainText,
            SqlNVarchar password)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar SignByCertificate(
            SqlInt certificateId,
            Text clearText)
        {
            throw new NotInExpressionException();
        }

        public static SqlVarchar SignByCertificate(
            SqlInt certificateId,
            Text clearText,
            SqlNVarchar password)
        {
            throw new NotInExpressionException();
        }

        public static SqlVariant SymmetricKeyProperty(
            SqlInt keyId,
            Text property)
        {
            throw new NotInExpressionException();
        }

        public static SqlBit VerifySignedByCertificate(
            SqlInt certificateId,
            Text signedData,
            SqlVarbinary signature)
        {
            throw new NotInExpressionException();
        }

        public static SqlBit VerifySignedByAsymmetricKey(
            SqlInt asymmetricKeyId,
            Text clearText,
            SqlVarbinary signature)
        {
            throw new NotInExpressionException();
        }
    }
}
