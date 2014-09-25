using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IInlineQuoteElement : IHtmlElement<IInlineQuoteElement>
    {
        /// <summary>
        /// Specifies the source of the quotation
        /// </summary>
        IInlineQuoteElement WithCite(string source);
    }
}
