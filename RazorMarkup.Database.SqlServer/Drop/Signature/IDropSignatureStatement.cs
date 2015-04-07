namespace RazorMarkup.Database.SqlServer.Drop.Signature
{
    public interface IDropSignatureStatement : IHideObjectMethods
    {
        IDropSignatureCryptoType By();
    }
}
