using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class HeadElements : IHeadElements
    {
        public ILinkElement StylesheetLink()
        {
            return new LinkElement();
        }

        public ILinkElement Link(string relationshipType)
        {
            return new LinkElement(relationshipType);
        }

        public IStyleElement BeginStylesheet()
        {
            return new StyleElement();
        }

        public IHtmlString EndStylesheet()
        {
            return new HtmlString("</style>");
        }

        public IBaseElement BaseUrl()
        {
            return new BaseElement();
        }
    }
}
