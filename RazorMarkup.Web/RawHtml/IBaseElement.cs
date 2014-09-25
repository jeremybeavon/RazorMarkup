using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IBaseElement : IHtmlElement<IBaseElement>
    {
        IBaseElement WithUrl(string url);

        IBaseElement WithTarget(PageLinkTarget target);
    }
}
