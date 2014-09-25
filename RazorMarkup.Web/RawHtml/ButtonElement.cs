using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class ButtonElement : AbstractHtmlElement<IButtonElement>, IButtonElement
    {
        public ButtonElement()
            : base("button", false)
        {
        }

        public IButtonElement WithDisabled()
        {
            return AddEmptyAttribute("disabled");
        }

        public IButtonElement WithName(string name)
        {
            return AddAttribute("name", name);
        }

        public IButtonElement WithValue(string value)
        {
            return AddAttribute("value", value);
        }

        public IButtonElement WithType(ButtonType type)
        {
            return AddAttribute("type", type.ToHtmlString());
        }
    }
}
