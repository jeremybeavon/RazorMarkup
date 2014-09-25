using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public interface IBidirectionalTextOverrideElement : 
        IHtmlElement<IBidirectionalTextOverrideElement>
    {
        IBidirectionalTextOverrideElement WithTextDirection(TextDirectionOverride textDirection);
    }
}
