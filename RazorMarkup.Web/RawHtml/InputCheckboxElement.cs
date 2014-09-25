using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class InputCheckboxElement : AbstractInputElement<IInputCheckboxElement>, IInputCheckboxElement
    {
        public InputCheckboxElement()
            : base("checkbox")
        {
        }

        public IInputCheckboxElement WithChecked()
        {
            return AddAttribute("checked", "checked");
        }

        public IInputCheckboxElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputCheckboxElement WithValue(string value)
        {
            return AddAttribute("value", value);
        }
    }
}
