using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class EmbeddedObjectElements : IEmbeddedObjectElements
    {
        public IObjectElement Begin()
        {
            return new ObjectElement();
        }

        public IHtmlString End()
        {
            return new HtmlString("</object>");
        }

        public IParameterElement Parameter()
        {
            return new ParameterElement();
        }
    }
}
