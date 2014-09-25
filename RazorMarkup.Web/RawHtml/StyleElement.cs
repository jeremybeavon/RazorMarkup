using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class StyleElement : AbstractHtmlElement<IStyleElement>, IStyleElement
    {
        private bool hasTypeAttribute;

        public StyleElement()
            : base("style", false)
        {
        }

        public IStyleElement IgnoreTypeAttribute()
        {
            hasTypeAttribute = true;
            return this;
        }

        public IStyleElement WithMedia(IMediaOperator media)
        {
            return AddAttribute("media", media.ToHtmlString());
        }

        public IStyleElement WithType(string type)
        {
            hasTypeAttribute = true;
            return AddAttribute("type", type);
        }

        public override string ToHtmlString()
        {
            if (!hasTypeAttribute)
            {
                AddAttribute("type", "text/css");
            }

            return base.ToHtmlString();
        }
    }
}
