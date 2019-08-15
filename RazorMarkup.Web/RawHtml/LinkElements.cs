using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class LinkElements : ILinkElements
    {
        public IPageLinkElement BeginPageLink()
        {
            return new PageLinkElement();
        }

        public IHtmlString EndPageLink()
        {
            return new HtmlString("</a>");
        }
    }
}
