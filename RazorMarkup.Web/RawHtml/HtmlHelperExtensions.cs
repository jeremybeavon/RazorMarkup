using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RazorMarkup.Web.RawHtml
{
    public static class HtmlHelperExtensions
    {
        public static IRawHtml Raw(this HtmlHelper html)
        {
            return new RawHtml();
        }
    }
}
