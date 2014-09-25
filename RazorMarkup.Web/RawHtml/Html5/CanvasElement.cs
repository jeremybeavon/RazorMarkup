using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    internal sealed class CanvasElement : AbstractHtmlElement<ICanvasElement>, ICanvasElement
    {
        public CanvasElement()
            : base("canvas", false)
        {
        }

        public ICanvasElement WithHeight(int pixels)
        {
            return AddAttribute("height", pixels.ToString());
        }

        public ICanvasElement WithWidth(int pixels)
        {
            return AddAttribute("width", pixels.ToString());
        }
    }
}
