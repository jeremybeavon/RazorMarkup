using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class EmbedElement : AbstractHtmlElement<IEmbedElement>, IEmbedElement
    {
        public EmbedElement()
            : base("embed", true)
        {
        }

        public IEmbedElement WithHeight(int pixels)
        {
            return AddAttribute("height", pixels.ToString());
        }

        public IEmbedElement WithUrl(string url)
        {
            return AddAttribute("src", url);
        }

        public IEmbedElement WithType(string type)
        {
            return AddAttribute("type", type);
        }

        public IEmbedElement WithWidth(int pixels)
        {
            return AddAttribute("width", pixels.ToString());
        }
    }
}
