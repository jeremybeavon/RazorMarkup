using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml
{
    public interface IRectangleAreaElement : IAreaElement<IRectangleAreaElement>
    {
        IRectangleAreaElement WithCoordinates(int left, int top, int right, int bottom);
    }
}
