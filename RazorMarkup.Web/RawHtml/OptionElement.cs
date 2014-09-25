using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class OptionElement : AbstractHtmlElement<IOptionElement>, IOptionElement
    {
        public OptionElement()
            : base("option", false)
        {
        }

        public IOptionElement WithDisabled()
        {
            return AddEmptyAttribute("disabled");
        }

        public IOptionElement WithShortText(string shortText)
        {
            return AddAttribute("label", shortText);
        }

        public IOptionElement WithSelected()
        {
            return AddEmptyAttribute("selected");
        }

        public IOptionElement WithValue(string value)
        {
            return AddAttribute("value", value);
        }
    }
}
