using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.Css
{
    internal abstract class AbstractProperties
    {
        protected static string Property(string name, string value)
        {
            return string.Format("{0}: {1};", name, value);
        }
    }
}
