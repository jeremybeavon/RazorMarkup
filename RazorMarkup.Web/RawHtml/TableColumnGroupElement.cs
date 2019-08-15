namespace RazorMarkup.Web.RawHtml
{
    internal sealed class TableColumnGroupElement : AbstractHtmlElement<ITableColumnGroupElement>, ITableColumnGroupElement
    {
        public TableColumnGroupElement()
            : base("colgroup", false)
        {
        }

        public ITableColumnGroupElement WithSpan(int span)
        {
            return AddAttribute("span", span.ToString());
        }
    }
}
