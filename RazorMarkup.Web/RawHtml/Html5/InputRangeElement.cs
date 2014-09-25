using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class InputRangeElement : AbstractInputElement<IInputRangeElement>, IInputRangeElement
    {
        public InputRangeElement()
            : base("range")
        {
        }

        public IInputRangeElement WithAutocompleteOn()
        {
            return AddAttribute("autocomplete", "on");
        }

        public IInputRangeElement WithAutocompleteOff()
        {
            return AddAttribute("autocomplete", "off");
        }
        
        public IInputRangeElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }

        public IInputRangeElement WithMax(double max)
        {
            return AddAttribute("max", max.ToString());
        }

        public IInputRangeElement WithMin(double min)
        {
            return AddAttribute("min", min.ToString());
        }

        public IInputRangeElement WithValue(double value)
        {
            return AddAttribute("value", value.ToString());
        }
    }
}
