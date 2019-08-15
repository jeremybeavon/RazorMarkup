using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class BlockElements : IBlockElements
    {
        public IHtmlElement Begin()
        {
            return new HtmlElement("div");
        }

        public IHtmlString End()
        {
            return new HtmlString("</div>");
        }

        public IHtmlElement BeginInline()
        {
            return new HtmlElement("span");
        }

        public IHtmlString EndInline()
        {
            return new HtmlString("</span>");
        }
    }
}
