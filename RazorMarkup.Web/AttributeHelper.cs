using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RazorMarkup.Web
{
    internal static class AttributeHelper
    {
        public static string GetAttribute(string name, string value)
        {
            return string.Format(" {0} = \"{1}\"", name, HttpUtility.HtmlAttributeEncode(value));
        }
    }
}
