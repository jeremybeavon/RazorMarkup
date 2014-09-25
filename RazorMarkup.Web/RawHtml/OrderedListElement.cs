using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class OrderedListElement : AbstractHtmlElement<IOrderedListElement>, IOrderedListElement
    {
        public OrderedListElement()
            : base("ol", false)
        {
        }

        public IOrderedListElement WithStart(int startNumber)
        {
            return AddAttribute("start", startNumber.ToString());
        }

        public IOrderedListElement WithType(OrderedListType type)
        {
            return AddAttribute("type", type.ToHtmlString());
        }
    }
}
