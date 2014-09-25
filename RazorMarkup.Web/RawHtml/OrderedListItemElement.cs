using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class OrderedListItemElement : AbstractHtmlElement<IOrderedListItemElement>, IOrderedListItemElement
    {
        public OrderedListItemElement()
            : base("li", false)
        {
        }

        public IOrderedListItemElement WithValue(int value)
        {
            return AddAttribute("value", value.ToString());
        }
    }
}
