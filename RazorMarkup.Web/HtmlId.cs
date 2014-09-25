using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web
{
    public sealed class HtmlId : HtmlString
    {
        public HtmlId(string html)
            : base(html)
        {
        }
    }
}
