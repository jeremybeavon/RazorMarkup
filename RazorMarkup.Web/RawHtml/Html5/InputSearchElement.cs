using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class InputSearchElement : AbstractInputElement<IInputSearchElement>, IInputSearchElement
    {
        public InputSearchElement()
            : base("search")
        {
        }

        public IInputSearchElement WithAutocompleteOn()
        {
            return AddAttribute("autocomplete", "on");
        }

        public IInputSearchElement WithAutocompleteOff()
        {
            return AddAttribute("autocomplete", "off");
        }
        
        public IInputSearchElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputSearchElement WithRegularExpression(string pattern)
        {
            return AddAttribute("pattern", pattern);
        }

        public IInputSearchElement WithPlaceholder(string text)
        {
            return AddAttribute("placeholder", text);
        }

        public IInputSearchElement WithRequired()
        {
            return AddAttribute("required", "required");
        }

        public IInputSearchElement WithWidth(int numberOfCharacters)
        {
            return AddAttribute("size", numberOfCharacters.ToString());
        }

        public IInputSearchElement WithValue(string value)
        {
            return AddAttribute("value", value);
        }
    }
}
