namespace RazorMarkup.Web.RawHtml
{
    public interface ITableHeaderCellElement : IHtmlElement<ITableHeaderCellElement>
    {
        ITableHeaderCellElement WithColumnSpan(int columnSpan);

        ITableHeaderCellElement WithRowSpan(int rowSpan);

        ITableHeaderCellElement WithScope(TableHeaderCellElementScope scope);
    }
}
