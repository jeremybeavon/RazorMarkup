using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class QuoteElement : IQuoteElement
    {
        public IBlockQuoteElement BeginBlock()
        {
            return new BlockQuoteElement();
        }

        public IHtmlString EndBlock()
        {
            return new HtmlString("</blockquote>");
        }

        public IInlineQuoteElement BeginInline()
        {
            return new InlineQuoteElement();
        }

        public IHtmlString EndInline()
        {
            return new HtmlString("</q>");
        }
    }
}
