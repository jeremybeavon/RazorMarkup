using System;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class InputDateElement : AbstractInputElement<IInputDateElement>, IInputDateElement
    {
        public InputDateElement()
            : base("date")
        {
        }

        public IInputDateElement WithAutocompleteOn()
        {
            return AddAttribute("autocomplete", "on");
        }

        public IInputDateElement WithAutocompleteOff()
        {
            return AddAttribute("autocomplete", "off");
        }
        
        public IInputDateElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }

        public IInputDateElement WithMax(DateTime max)
        {
            return AddAttribute("max", max.ToString("yyyy-MM-dd"));
        }

        public IInputDateElement WithMin(DateTime min)
        {
            return AddAttribute("min", min.ToString("yyyy-MM-dd"));
        }

        public IInputDateElement WithRequired()
        {
            return AddAttribute("required", "required");
        }

        public IInputDateElement WithValue(DateTime value)
        {
            return AddAttribute("value", value.ToString("yyyy-MM-dd"));
        }
    }
}
