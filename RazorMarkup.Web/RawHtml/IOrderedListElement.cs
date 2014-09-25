using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IOrderedListElement : IHtmlElement<IOrderedListElement>
    {
        IOrderedListElement WithStart(int startNumber);

        IOrderedListElement WithType(OrderedListType type);
    }
}
