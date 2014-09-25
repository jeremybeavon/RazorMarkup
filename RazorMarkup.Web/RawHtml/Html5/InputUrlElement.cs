using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class InputUrlElement : AbstractInputElement<IInputUrlElement>, IInputUrlElement
    {
        public InputUrlElement()
            : base("url")
        {
        }

        public IInputUrlElement WithAutocompleteOn()
        {
            return AddAttribute("autocomplete", "on");
        }

        public IInputUrlElement WithAutocompleteOff()
        {
            return AddAttribute("autocomplete", "off");
        }
        
        public IInputUrlElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputUrlElement WithRegularExpression(string pattern)
        {
            return AddAttribute("pattern", pattern);
        }

        public IInputUrlElement WithPlaceholder(string text)
        {
            return AddAttribute("placeholder", text);
        }

        public IInputUrlElement WithRequired()
        {
            return AddAttribute("required", "required");
        }

        public IInputUrlElement WithWidth(int numberOfCharacters)
        {
            return AddAttribute("size", numberOfCharacters.ToString());
        }

        public IInputUrlElement WithValue(string value)
        {
            return AddAttribute("value", value);
        }
    }
}
