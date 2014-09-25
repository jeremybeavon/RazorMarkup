using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class InputHiddenElement : AbstractInputElement<IInputHiddenElement>, IInputHiddenElement
    {
        public InputHiddenElement()
            : base("hidden")
        {
        }

        public IInputHiddenElement WithValue(string value)
        {
            return AddAttribute("value", value);
        }
    }
}
