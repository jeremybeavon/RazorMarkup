using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class InputDateTimeElement : AbstractInputElement<IInputDateTimeElement>, IInputDateTimeElement
    {
        public InputDateTimeElement()
            : base("datetime")
        {
        }

        public IInputDateTimeElement WithAutocompleteOn()
        {
            return AddAttribute("autocomplete", "on");
        }

        public IInputDateTimeElement WithAutocompleteOff()
        {
            return AddAttribute("autocomplete", "off");
        }
        
        public IInputDateTimeElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputDateTimeElement WithMax(DateTime max)
        {
            return AddAttribute("max", max.ToString("yyyy-MM-ddTHH:mm:ss"));
        }

        public IInputDateTimeElement WithMin(DateTime min)
        {
            return AddAttribute("min", min.ToString("yyyy-MM-ddTHH:mm:ss"));
        }

        public IInputDateTimeElement WithRequired()
        {
            return AddAttribute("required", "required");
        }

        public IInputDateTimeElement WithValue(DateTime value)
        {
            return AddAttribute("value", value.ToString("yyyy-MM-ddTHH:mm:ss"));
        }
    }
}
