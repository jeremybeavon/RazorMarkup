using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class ProgressElement : AbstractHtmlElement<IProgressElement>, IProgressElement
    {
        public ProgressElement()
            : base("progress", false)
        {
        }

        public IProgressElement WithMax(double maxValue)
        {
            return AddAttribute("max", maxValue.ToString());
        }

        public IProgressElement WithValue(double value)
        {
            return AddAttribute("value", value.ToString());
        }
    }
}
