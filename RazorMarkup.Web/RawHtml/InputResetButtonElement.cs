using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class InputResetButtonElement : AbstractInputElement<IInputResetButtonElement>, IInputResetButtonElement
    {
        public InputResetButtonElement()
            : base("reset")
        {
        }

        public IInputResetButtonElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputResetButtonElement WithText(string text)
        {
            return AddAttribute("value", text);
        }
    }
}
