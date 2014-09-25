using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal abstract class AbstractInputElement<TElement> : AbstractHtmlElement<TElement>, IInputElement<TElement>
        where TElement : IInputElement<TElement>
    {
        public AbstractInputElement(string inputType)
            : base("input", true)
        {
            AddAttribute("type", inputType);
        }

        public TElement WithReadonly()
        {
            return AddAttribute("readonly", "readonly");
        }

        public TElement WithName(HtmlName name)
        {
            return AddAttribute("name", name.ToHtmlString());
        }
    }
}
