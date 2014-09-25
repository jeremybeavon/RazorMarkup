using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface ITableHeaderCellElement : IHtmlElement<ITableHeaderCellElement>
    {
        ITableHeaderCellElement WithColumnSpan(int columnSpan);

        ITableHeaderCellElement WithRowSpan(int rowSpan);

        ITableHeaderCellElement WithScope(TableHeaderCellElementScope scope);
    }
}
