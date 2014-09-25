using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public sealed class TableHeaderCellElementScope : HtmlString
    {
        public static readonly TableHeaderCellElementScope Column = new TableHeaderCellElementScope("col");

        public static readonly TableHeaderCellElementScope Row = new TableHeaderCellElementScope("row");

        public static readonly TableHeaderCellElementScope ColumnGroup = new TableHeaderCellElementScope("colspan");

        public static readonly TableHeaderCellElementScope RowGroup = new TableHeaderCellElementScope("rowspan");

        public TableHeaderCellElementScope(string html)
            : base(html)
        {
        }
    }
}
