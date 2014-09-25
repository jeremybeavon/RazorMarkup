using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web
{
    public abstract class AbstractHtmlString : IHtmlString
    {
        public abstract string ToHtmlString();

        public override string ToString()
        {
            return ToHtmlString();
        }
    }
}
