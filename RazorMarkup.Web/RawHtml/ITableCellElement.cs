namespace RazorMarkup.Web.RawHtml
{
    public interface ITableCellElement : IHtmlElement<ITableCellElement>
    {
        ITableCellElement WithColumnSpan(int columnSpan);

        ITableCellElement WithRowSpan(int rowSpan);

        ITableCellElement WithHeaders(params string[] headers);
    }
}
