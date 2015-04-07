namespace RazorMarkup.Database.SqlServer.Drop.Signature
{
    public interface IDropSignatureAnd : ISqlString, IHideObjectMethods
    {
        IDropSignatureCryptoType And();
    }
}
