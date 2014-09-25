using System.ComponentModel.Composition;
using RazorMarkup.Database.SqlServer.Constants;
using RazorMarkup.Database.SqlServer.Types;
using RazorMarkup.Database.SqlServer.Types.Wrappers;

namespace RazorMarkup.Database.SqlServer.Expressions.Functions
{
    [Export(typeof(IFunctionRegistrations))]
    public sealed class CryptographicFunctionRegistrations : IFunctionRegistrations
    {
        public void RegisterFunctions(IFunctionRegistrationManager functionRegistrationManager)
        {
            functionRegistrationManager.Register(FunctionNames.AsymmetricKeyId, () => CryptographicFunctions.AsymmetricKeyId(null));
            functionRegistrationManager.Register(
                FunctionNames.AsymmetricKeyProperty,
                () => CryptographicFunctions.AsymmetricKeyProperty(null, null));
            functionRegistrationManager.Register(
                FunctionNames.CertificateProperty,
                () => CryptographicFunctions.CertificateProperty(null, null));
            functionRegistrationManager.Register(
                FunctionNames.CertificateId,
                () => CryptographicFunctions.CertificateId((CertificateName)null),
                () => CryptographicFunctions.CertificateId((Text)null));
            functionRegistrationManager.Register(
                FunctionNames.CryptographicRandom,
                () => CryptographicFunctions.CryptographicRandom(null),
                () => CryptographicFunctions.CryptographicRandom(null, null));
            functionRegistrationManager.Register(
                FunctionNames.DecryptByAsymmetricKey,
                () => CryptographicFunctions.DecryptByAsymmetricKey(null, null),
                () => CryptographicFunctions.DecryptByAsymmetricKey(null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.DecryptByCertificate,
                () => CryptographicFunctions.DecryptByCertificate(null, null),
                () => CryptographicFunctions.DecryptByCertificate(null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.DecryptByKey,
                () => CryptographicFunctions.DecryptByKey(null),
                () => CryptographicFunctions.DecryptByKey(null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.DecryptByKeyUsingAsymmetricKey,
                () => CryptographicFunctions.DecryptByKeyUsingAsymmetricKey(null, null, null),
                () => CryptographicFunctions.DecryptByKeyUsingAsymmetricKey(null, null, null, null),
                () => CryptographicFunctions.DecryptByKeyUsingAsymmetricKey(null, null, null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.DecryptByKeyUsingCertificate,
                () => CryptographicFunctions.DecryptByKeyUsingCertificate(null, null, null),
                () => CryptographicFunctions.DecryptByKeyUsingCertificate(null, null, null, null),
                () => CryptographicFunctions.DecryptByKeyUsingCertificate(null, null, null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.DecryptByPassPhrase,
                () => CryptographicFunctions.DecryptByPassPhrase(null, null),
                () => CryptographicFunctions.DecryptByPassPhrase(null, null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.EncryptByAsymmetricKey,
                () => CryptographicFunctions.EncryptByAsymmetricKey(null, null));
            functionRegistrationManager.Register(
                FunctionNames.EncryptByCertificate,
                () => CryptographicFunctions.EncryptByCertificate(null, null));
            functionRegistrationManager.Register(
                FunctionNames.EncryptByKey,
                () => CryptographicFunctions.EncryptByKey(null, null),
                () => CryptographicFunctions.EncryptByKey(null, null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.EncryptByPassPhrase,
                () => CryptographicFunctions.EncryptByPassPhrase(null, null),
                () => CryptographicFunctions.EncryptByPassPhrase(null, null, null, null));
            functionRegistrationManager.Register(FunctionNames.HashBytes, () => CryptographicFunctions.HashBytes(null, null));
            functionRegistrationManager.Register(
                FunctionNames.IsObjectSigned,
                () => CryptographicFunctions.IsObjectSigned(null, null, null, null));
            functionRegistrationManager.Register(FunctionNames.KeyGuid, () => CryptographicFunctions.KeyGuid(null));
            functionRegistrationManager.Register(FunctionNames.KeyId, () => CryptographicFunctions.KeyId(null));
            functionRegistrationManager.Register(
                FunctionNames.KeyName,
                () => CryptographicFunctions.KeyName((SqlUniqueIdentifier)null),
                () => CryptographicFunctions.KeyName((SqlVarbinary)null));
            functionRegistrationManager.Register(
                FunctionNames.SignByAsymmetricKey,
                () => CryptographicFunctions.SignByAsymmetricKey(null, null),
                () => CryptographicFunctions.SignByAsymmetricKey(null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.SignByCertificate,
                () => CryptographicFunctions.SignByCertificate(null, null),
                () => CryptographicFunctions.SignByCertificate(null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.SymmetricKeyProperty,
                () => CryptographicFunctions.SymmetricKeyProperty(null, null));
            functionRegistrationManager.Register(
                FunctionNames.VerifySignedByAsymmetricKey,
                () => CryptographicFunctions.VerifySignedByCertificate(null, null, null));
            functionRegistrationManager.Register(
                FunctionNames.VerifySignedByCertificate,
                () => CryptographicFunctions.VerifySignedByAsymmetricKey(null, null, null));
        }
    }
}
