namespace RazorMarkup.Web.RawHtml
{
    internal sealed class TableColumnElement : AbstractHtmlElement<ITableColumnElement>, ITableColumnElement
    {
        public TableColumnElement()
            : base("col", true)
        {
        }

        public ITableColumnElement WithSpan(int span)
        {
            return AddAttribute("span", span.ToString());
        }
    }
}
