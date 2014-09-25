using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorMarkup.Web.RawHtml.Html5
{
    public static class HeadElementsExtensions
    {
        /// <summary>
        /// The type attribute is no longer required in HTML 5.
        /// </summary>
        [BrowserCompatibility(BrowserType.Chrome, IsSupported = true)]
        [BrowserCompatibility(BrowserType.InternetExplorer, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Firefox, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Safari, IsSupported = true)]
        [BrowserCompatibility(BrowserType.Opera, IsSupported = true)]
        public static IStyleElement BeginHtml5Stylesheet(this IHeadElements head)
        {
            return new StyleElement().IgnoreTypeAttribute();
        }
    }
}
