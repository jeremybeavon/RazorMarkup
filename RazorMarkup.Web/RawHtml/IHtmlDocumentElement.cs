using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IHtmlDocumentElement : IHtmlElement<IHtmlDocumentElement>
    {
        IHtmlDocumentElement WithXmlNamespace();
    }
}
