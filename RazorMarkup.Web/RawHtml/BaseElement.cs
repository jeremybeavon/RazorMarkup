using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class BaseElement : AbstractHtmlElement<IBaseElement>, IBaseElement
    {
        public BaseElement()
            : base("base", true)
        {
        }

        public IBaseElement WithUrl(string url)
        {
            return AddAttribute("href", url);
        }

        public IBaseElement WithTarget(PageLinkTarget target)
        {
            return AddAttribute("target", target.ToHtmlString());
        }
    }
}
