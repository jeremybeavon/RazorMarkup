using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class InputTimeElement : AbstractInputElement<IInputTimeElement>, IInputTimeElement
    {
        public InputTimeElement()
            : base("time")
        {
        }

        public IInputTimeElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }
        
        public IInputTimeElement WithMax(DateTime max)
        {
            return AddAttribute("max", max.ToString("HH:mm:ss"));
        }

        public IInputTimeElement WithMin(DateTime min)
        {
            return AddAttribute("min", min.ToString("HH:mm:ss"));
        }
        
        public IInputTimeElement WithValue(DateTime value)
        {
            return AddAttribute("value", value.ToString("HH:mm:ss"));
        }
    }
}
