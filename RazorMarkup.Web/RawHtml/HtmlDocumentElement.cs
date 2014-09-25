using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class HtmlDocumentElement : AbstractHtmlElement<IHtmlDocumentElement>, IHtmlDocumentElement
    {
        public HtmlDocumentElement()
            : base("html", false)
        {
        }

        public IHtmlDocumentElement WithXmlNamespace()
        {
            return AddAttribute("xmlns", "http://www.w3.org/1999/xhtml");
        }
    }
}
