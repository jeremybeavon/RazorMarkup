using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class TableElements : ITableElements
    {
        public IHtmlElement Begin()
        {
            return new HtmlElement("table");
        }

        public IHtmlString End()
        {
            return new HtmlString("</table>");
        }

        public IHtmlElement BeginCaption()
        {
            return new HtmlElement("caption");
        }

        public IHtmlString EndCaption()
        {
            return new HtmlString("</caption>");
        }

        public ITableColumnElement Column()
        {
            return new TableColumnElement();
        }

        public ITableColumnGroupElement BeginColumnGroup()
        {
            return new TableColumnGroupElement();
        }

        public IHtmlString EndColumnGroup()
        {
            return new HtmlString("</colgroup>");
        }

        public IHtmlElement BeginHeader()
        {
            return new HtmlElement("thead");
        }

        public IHtmlString EndHeader()
        {
            return new HtmlString("</thead>");
        }

        public IHtmlElement BeginBody()
        {
            return new HtmlElement("tbody");
        }

        public IHtmlString EndBody()
        {
            return new HtmlString("</tbody>");
        }

        public IHtmlElement BeginFooter()
        {
            return new HtmlElement("tfoot");
        }

        public IHtmlString EndFooter()
        {
            return new HtmlString("</tfoot>");
        }

        public ITableRowElements Row()
        {
            return new TableRowElements();
        }
    }
}
