namespace RazorMarkup.Web.RawHtml
{
    public interface ITableColumnGroupElement : IHtmlElement<ITableColumnGroupElement>
    {
        /// <summary>
        /// Specifies the number of columns a column group should span
        /// </summary>
        ITableColumnGroupElement WithSpan(int span);
    }
}
