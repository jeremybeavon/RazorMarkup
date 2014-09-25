using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IBlockQuoteElement : IHtmlElement<IBlockQuoteElement>
    {
        /// <summary>
        /// Specifies the source of the quotation
        /// </summary>
        IBlockQuoteElement WithCite(string source);
    }
}
