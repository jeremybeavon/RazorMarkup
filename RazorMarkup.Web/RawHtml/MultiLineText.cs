using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class MultiLineText : IMultiLineText
    {
        public ITextAreaElement Begin()
        {
            return new TextAreaElement();
        }

        public IHtmlString End()
        {
            return new HtmlString("</textarea>");
        }
    }
}
