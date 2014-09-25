using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface ICircleAreaElement : IAreaElement<ICircleAreaElement>
    {
        ICircleAreaElement WithCoordinates(int centerX, int centerY, int radius);
    }
}
