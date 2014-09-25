using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    internal sealed class ImageMapElements : IImageMapElements
    {
        public IHtmlElement Begin(HtmlName name)
        {
            return new HtmlElement("map").AddAttribute("name", name.ToHtmlString());
        }

        public IHtmlString End()
        {
            return new HtmlString("</map>");
        }

        public IDefaultAreaElement DefaultArea()
        {
            return new DefaultAreaElement();
        }

        public ICircleAreaElement CircleArea()
        {
            return new CircleAreaElement();
        }

        public IPolygonAreaElement PolygonArea()
        {
            return new PolygonAreaElement();
        }

        public IRectangleAreaElement RectangleArea()
        {
            return new RectangleAreaElement();
        }
    }
}
