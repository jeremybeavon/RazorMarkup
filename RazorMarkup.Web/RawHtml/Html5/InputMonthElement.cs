using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class InputMonthElement : AbstractInputElement<IInputMonthElement>, IInputMonthElement
    {
        public InputMonthElement()
            : base("month")
        {
        }

        public IInputMonthElement WithDisabled()
        {
            return AddAttribute("disabled", "disabled");
        }

        public IInputMonthElement WithMax(DateTime max)
        {
            return AddAttribute("max", max.ToString("yyyy-MM"));
        }

        public IInputMonthElement WithMin(DateTime min)
        {
            return AddAttribute("min", min.ToString("yyyy-MM"));
        }
        
        public IInputMonthElement WithValue(DateTime value)
        {
            return AddAttribute("value", value.ToString("yyyy-MM"));
        }
    }
}
