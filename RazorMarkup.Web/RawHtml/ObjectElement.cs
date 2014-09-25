using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class ObjectElement : AbstractHtmlElement<IObjectElement>, IObjectElement
    {
        public ObjectElement()
            : base("object", false)
        {
        }

        public IObjectElement WithUrl(string url)
        {
            return AddAttribute("data", url);
        }

        public IObjectElement WithHeight(int pixels)
        {
            return AddAttribute("height", pixels.ToString());
        }

        public IObjectElement WithName(string name)
        {
            return AddAttribute("name", name);
        }

        public IObjectElement WithType(string type)
        {
            return AddAttribute("type", type);
        }

        public IObjectElement WithImageMap(string name)
        {
            return AddAttribute("usemap", "#" + name);
        }

        public IObjectElement WithWidth(int pixels)
        {
            return AddAttribute("width", pixels.ToString());
        }
    }
}
