using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class InputColorPickerElement : AbstractInputElement<IInputColorPickerElement>, IInputColorPickerElement
    {
        public InputColorPickerElement()
            : base("color")
        {
        }

        public IInputColorPickerElement WithAutocompleteOn()
        {
            return AddAttribute("autocomplete", "on");
        }

        public IInputColorPickerElement WithAutocompleteOff()
        {
            return AddAttribute("autocomplete", "off");
        }

        public IInputColorPickerElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
    }
}
