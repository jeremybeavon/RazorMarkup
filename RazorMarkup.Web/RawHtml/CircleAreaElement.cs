using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class CircleAreaElement : AbstractAreaElement<ICircleAreaElement>, ICircleAreaElement
    {
        public CircleAreaElement()
            : base("circle")
        {
        }

        public ICircleAreaElement WithCoordinates(int centerX, int centerY, int radius)
        {
            return AddAttribute("coords", string.Join(",", centerX, centerY, radius));
        }
    }
}
