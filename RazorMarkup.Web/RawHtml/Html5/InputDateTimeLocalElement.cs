using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class InputDateTimeLocalElement : AbstractInputElement<IInputDateTimeLocalElement>, IInputDateTimeLocalElement
    {
        public InputDateTimeLocalElement()
            : base("datetime-local")
        {
        }

        public IInputDateTimeLocalElement WithAutocompleteOn()
        {
            return AddAttribute("autocomplete", "on");
        }

        public IInputDateTimeLocalElement WithAutocompleteOff()
        {
            return AddAttribute("autocomplete", "off");
        }
        
        public IInputDateTimeLocalElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }

        public IInputDateTimeLocalElement WithMax(DateTime max)
        {
            return AddAttribute("max", max.ToString("yyyy-MM-ddTHH:mm:ss"));
        }

        public IInputDateTimeLocalElement WithMin(DateTime min)
        {
            return AddAttribute("min", min.ToString("yyyy-MM-ddTHH:mm:ss"));
        }

        public IInputDateTimeLocalElement WithRequired()
        {
            return AddAttribute("required", "required");
        }

        public IInputDateTimeLocalElement WithValue(DateTime value)
        {
            return AddAttribute("value", value.ToString("yyyy-MM-ddTHH:mm:ss"));
        }
    }
}
