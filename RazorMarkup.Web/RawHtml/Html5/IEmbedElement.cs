using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public interface IEmbedElement : IHtmlElement<IEmbedElement>
    {
        IEmbedElement WithHeight(int pixels);

        IEmbedElement WithUrl(string url);

        IEmbedElement WithType(string type);

        IEmbedElement WithWidth(int pixels);
    }
}
