using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class InputPasswordElement : AbstractInputElement<IInputPasswordElement>, IInputPasswordElement
    {
        public InputPasswordElement()
            : base("password")
        {
        }

        public IInputPasswordElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputPasswordElement WithWidth(int numberOfCharacters)
        {
            return AddAttribute("size", numberOfCharacters.ToString());
        }
        
        public IInputPasswordElement WithValue(string value)
        {
            return AddAttribute("value", value);
        }
    }
}
