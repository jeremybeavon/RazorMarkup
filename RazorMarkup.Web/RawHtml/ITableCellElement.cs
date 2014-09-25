using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface ITableCellElement : IHtmlElement<ITableCellElement>
    {
        ITableCellElement WithColumnSpan(int columnSpan);

        ITableCellElement WithRowSpan(int rowSpan);

        ITableCellElement WithHeaders(params string[] headers);
    }
}
