namespace RazorMarkup.Web.RawHtml
{
    public interface IHtmlDocumentElement : IHtmlElement<IHtmlDocumentElement>
    {
        IHtmlDocumentElement WithXmlNamespace();
    }
}
