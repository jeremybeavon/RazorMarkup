namespace RazorMarkup.Database.SqlServer.Drop.Signature
{
    public interface IDropSignatureCryptoType : IHideObjectMethods
    {
        IDropSignatureAnd Certificate(CertificateName certificateName);

        IDropSignatureAnd AysmmetricKey(AsymmetricKeyName asymmetricKeyName);
    }
}
