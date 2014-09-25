using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class InputRadioButtonElement : AbstractInputElement<IInputRadioButtonElement>, IInputRadioButtonElement
    {
        public InputRadioButtonElement(string value)
            : base("radio")
        {
            AddAttribute("value", value);
        }

        public IInputRadioButtonElement WithChecked()
        {
            return AddAttribute("checked", "checked");
        }
        
        public IInputRadioButtonElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
    }
}
