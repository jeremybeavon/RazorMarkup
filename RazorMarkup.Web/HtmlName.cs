using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web
{
    public sealed class HtmlName : HtmlString
    {
        public HtmlName(string html)
            : base(html)
        {
        }
    }
}
