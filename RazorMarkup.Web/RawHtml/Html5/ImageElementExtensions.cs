using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class ImageElementExtensions
    {
        public static IFigureElements Figure(this IImageElement image)
        {
            return new FigureElements();
        }
    }
}
