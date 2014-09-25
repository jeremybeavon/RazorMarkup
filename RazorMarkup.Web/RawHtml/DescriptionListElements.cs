using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class DescriptionListElements : IDescriptionListElements
    {
        public IHtmlElement Begin()
        {
            return new HtmlElement("dl");
        }

        public IHtmlString End()
        {
            return new HtmlString("</dl>");
        }

        public IHtmlElement BeginTerm()
        {
            return new HtmlElement("dt");
        }

        public IHtmlString EndTerm()
        {
            return new HtmlString("</dt>");
        }

        public IHtmlElement BeginDescription()
        {
            return new HtmlElement("dd");
        }

        public IHtmlString EndDescription()
        {
            return new HtmlString("</dd>");
        }
    }
}
