﻿namespace RazorMarkup.Web.RawHtml
{
    internal sealed class TableHeaderCellElement : AbstractHtmlElement<ITableHeaderCellElement>, ITableHeaderCellElement
    {
        public TableHeaderCellElement()
            : base("th", false)
        {
        }

        public ITableHeaderCellElement WithColumnSpan(int columnSpan)
        {
            return AddAttribute("colspan", columnSpan.ToString());
        }

        public ITableHeaderCellElement WithRowSpan(int rowSpan)
        {
            return AddAttribute("rowspan", rowSpan.ToString());
        }

        public ITableHeaderCellElement WithScope(TableHeaderCellElementScope scope)
        {
            return AddAttribute("scope", scope.ToHtmlString());
        }
    }
}
