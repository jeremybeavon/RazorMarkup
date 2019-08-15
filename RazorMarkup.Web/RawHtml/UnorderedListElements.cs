using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class UnorderedListElements : IUnorderedListElements
    {
        public IHtmlElement Begin()
        {
            return new HtmlElement("ul");
        }

        public IHtmlString End()
        {
            return new HtmlString("</ul>");
        }

        public IHtmlElement BeginItem()
        {
            return new HtmlElement("li");
        }

        public IHtmlString EndItem()
        {
            return new HtmlString("</li>");
        }
    }
}
