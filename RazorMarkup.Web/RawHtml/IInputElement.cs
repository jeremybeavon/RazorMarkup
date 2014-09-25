using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IInputElement<TElement> : IHtmlElement<TElement>
        where TElement : IInputElement<TElement>
    {
        TElement WithReadonly();

        TElement WithName(HtmlName name);
    }
}
