using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal class HtmlElement : AbstractHtmlElement<IHtmlElement>,
        IHtmlElement
    {
        public HtmlElement(string elementName)
            : base(elementName, false)
        {
        }

        public HtmlElement(string elementName, bool isEmpty)
            : base(elementName, isEmpty)
        {
        }
    }
}
