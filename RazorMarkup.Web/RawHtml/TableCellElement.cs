using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class TableCellElement : AbstractHtmlElement<ITableCellElement>, ITableCellElement
    {
        public TableCellElement()
            : base("td", false)
        {
        }

        public ITableCellElement WithColumnSpan(int columnSpan)
        {
            return AddAttribute("colspan", columnSpan.ToString());
        }

        public ITableCellElement WithRowSpan(int rowSpan)
        {
            return AddAttribute("rowspan", rowSpan.ToString());
        }

        public ITableCellElement WithHeaders(params string[] headers)
        {
            return AddAttribute("headers", string.Join(" ", headers));
        }
    }
}
