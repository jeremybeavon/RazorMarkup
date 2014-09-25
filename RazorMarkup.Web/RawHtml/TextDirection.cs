using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web.RawHtml
{
    public sealed class TextDirection : HtmlString
    {
        public static readonly TextDirection Auto = new TextDirection("auto");

        public static readonly TextDirection LeftToRight = new TextDirection("ltr");

        public static readonly TextDirection RightToLeft = new TextDirection("rtl");

        public TextDirection(string html)
            : base(html)
        {
        }
    }
}
