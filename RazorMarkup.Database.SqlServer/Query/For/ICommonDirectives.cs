namespace RazorMarkup.Database.SqlServer.Query.For
{
    public interface ICommonDirectives<T> : IHideObjectMethods
    {
        IForXmlAnd<T> BinaryBase64();

        IForXmlAnd<T> Type();

        IForXmlAnd<T> Root();

        IForXmlAnd<T> Root(string rootName);
    }
}
