using System.Web;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class FigureElements : IFigureElements
    {
        public IHtmlElement Begin()
        {
            return new HtmlElement("figure");
        }

        public IHtmlString End()
        {
            return new HtmlString("</figure>");
        }

        public IHtmlElement BeginCaption()
        {
            return new HtmlElement("figcaption");
        }

        public IHtmlString EndCaption()
        {
            return new HtmlString("</figcaption>");
        }
    }
}
