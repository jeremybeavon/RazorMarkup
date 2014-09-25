using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class OrderedListElements : IOrderedListElements
    {
        public IOrderedListElement Begin()
        {
            return new OrderedListElement();
        }

        public IHtmlString End()
        {
            return new HtmlString("</ol>");
        }

        public IOrderedListItemElement BeginItem()
        {
            return new OrderedListItemElement();
        }

        public IHtmlString EndItem()
        {
            return new HtmlString("</li>");
        }
    }
}
