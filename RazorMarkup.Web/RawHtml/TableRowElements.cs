using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class TableRowElements : ITableRowElements
    {
        public IHtmlElement Begin()
        {
            return new HtmlElement("tr");
        }

        public IHtmlString End()
        {
            return new HtmlString("</tr>");
        }

        public ITableHeaderCellElement BeginHeaderCell()
        {
            return new TableHeaderCellElement();
        }

        public IHtmlString EndHeaderCell()
        {
            return new HtmlString("</th>");
        }

        public ITableCellElement BeginCell()
        {
            return new TableCellElement();
        }

        public IHtmlString EndCell()
        {
            return new HtmlString("</td>");
        }
    }
}
