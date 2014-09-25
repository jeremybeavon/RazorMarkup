using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
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
