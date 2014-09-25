using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class FieldsetElements : IFieldsetElements
    {
        public IFieldsetElement Begin()
        {
            return new FieldsetElement();
        }

        public IHtmlString End()
        {
            return new HtmlString("</fieldset>");
        }

        public IHtmlElement BeginLegend()
        {
            return new HtmlElement("legend");
        }

        public IHtmlString EndLegend()
        {
            return new HtmlString("</legend>");
        }
    }
}
