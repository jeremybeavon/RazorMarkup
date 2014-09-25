using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public interface IImageMapElements : IHideObjectMethods
    {
        IHtmlElement Begin(HtmlName name);

        IHtmlString End();

        /// <summary>
        /// Specifies the entire region
        /// </summary>
        IDefaultAreaElement DefaultArea();

        ICircleAreaElement CircleArea();

        IPolygonAreaElement PolygonArea();

        IRectangleAreaElement RectangleArea();
    }
}
